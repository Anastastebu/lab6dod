using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Оголошення необхідних полів класу
        int N = 1; // розмірність системи
        int i = 0; //
        int j = 0; //
        int Change; //

        double[,] A = new double[6, 6]; // матриця А
        double[] B = new double[6]; // вектор правої частини СЛАР
        double[] X = new double[6]; // вектор розв'язку СЛАР

        public Form1()
        {
            InitializeComponent();
        }

       

        private void Decomp(int N, ref int Change)
        {

            int k;
            double sum;
            double maxVal = 0;
            int maxRow = 1;

            for (i = 1; i <= N; i++)
            {
                if (Math.Abs(A[i, 1]) > maxVal)
                {
                    maxVal = Math.Abs(A[i, 1]);
                    maxRow = i;
                }
            }
            Change = maxRow;

            if (maxRow != 1)
            {
                for (j = 1; j <= N; j++)
                {
                    double temp = A[1, j];
                    A[1, j] = A[maxRow, j];
                    A[maxRow, j] = temp;
                }
            }

            if (A[1, 1] == 0)
            {
                MessageBox.Show("Помилка: Сингулярна матриця (a[1,1]=0) після перестановки.");
                return;
            }

            for (j = 2; j <= N; j++)
            {
                A[1, j] = A[1, j] / A[1, 1];
            }

            for (i = 2; i <= N; i++)
            {
                for (k = i; k <= N; k++)
                {
                    sum = 0;
                    for (j = 1; j <= i - 1; j++)
                    {
                        sum += A[k, j] * A[j, i];
                    }
                    A[k, i] = A[k, i] - sum;
                }

                if (A[i, i] == 0)
                {
                    MessageBox.Show($"Помилка: Сингулярна матриця (A[{i},{i}]=0) під час розкладу.");
                    return;
                }

                for (k = i + 1; k <= N; k++)
                {
                    sum = 0;
                    for (j = 1; j <= i - 1; j++)
                    {
                        sum += A[i, j] * A[j, k];
                    }
                    A[i, k] = (A[i, k] - sum) / A[i, i];
                }
            }


            // Виведення результату LU-розкладення у таблицю С
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    C_matrix_dgv[j, i].Value = Convert.ToString(A[i + 1, j + 1]);
                }
            }
        }


        private void Solve(int Change, int N)
        {

            int i, j;
            double sum;

            if (Change != 1)
            {
                double temp = B[1];
                B[1] = B[Change];
                B[Change] = temp;
            }

            if (A[1, 1] == 0) return;
            B[1] = B[1] / A[1, 1];

            for (i = 2; i <= N; i++)
            {
                sum = 0;
                for (j = 1; j <= i - 1; j++)
                {
                    sum += A[i, j] * B[j];
                }
                if (A[i, i] == 0) return;
                B[i] = (B[i] - sum) / A[i, i];
            }

            X[N] = B[N];

            for (i = 1; i <= N - 1; i++)
            {
                int k = N - i;
                sum = 0;
                for (j = k + 1; j <= N; j++)
                {
                    sum += A[k, j] * X[j];
                }
                X[k] = B[k] - sum;
            }

        }


        private void GaussSolve(int N)
        {
            // Використовуємо 1-базовану індексацію, як у масивах A і B
            double[,] a = (double[,])A.Clone(); // Клонуємо, щоб не змінити A для LU
            double[] b = (double[])B.Clone(); // Клонуємо B

            // Прямий хід (Forward Elimination) з частковим вибором
            for (int k = 1; k <= N - 1; k++)
            {
                // Пошук головного елемента (Pivoting)
                int maxRow = k;
                for (int i = k + 1; i <= N; i++)
                {
                    if (Math.Abs(a[i, k]) > Math.Abs(a[maxRow, k]))
                    {
                        maxRow = i;
                    }
                }

                // Обмін рядків в 'a'
                for (int j = k; j <= N; j++)
                {
                    double temp = a[k, j];
                    a[k, j] = a[maxRow, j];
                    a[maxRow, j] = temp;
                }
                // Обмін в 'b'
                double tempB = b[k];
                b[k] = b[maxRow];
                b[maxRow] = tempB;

                // Перевірка на нульовий елемент
                if (Math.Abs(a[k, k]) < 1e-10) // Використовуємо малу величину для порівняння
                {
                    MessageBox.Show("Помилка: Сингулярна матриця (Метод Гауса)");
                    return;
                }

                // Елімінація
                for (int i = k + 1; i <= N; i++)
                {
                    double factor = a[i, k] / a[k, k];
                    for (int j = k; j <= N; j++)
                    {
                        a[i, j] = a[i, j] - factor * a[k, j];
                    }
                    b[i] = b[i] - factor * b[k];
                }
            }

            // Зворотний хід (Back Substitution)
            for (int i = N; i >= 1; i--)
            {
                double sum = 0;
                for (int j = i + 1; j <= N; j++)
                {
                    sum += a[i, j] * X[j]; // X тут використовується для зберігання результату
                }
                if (Math.Abs(a[i, i]) < 1e-10)
                {
                    MessageBox.Show("Помилка: Система не має єдиного розв'язку (Метод Гауса)");
                    return;
                }
                X[i] = (b[i] - sum) / a[i, i]; // Записуємо результат в X
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            X_vector_dgv.ReadOnly = true;

            A_matrix_dgv.AllowUserToAddRows = false;
            B_vector_dgv.AllowUserToAddRows = false;
            X_vector_dgv.AllowUserToAddRows = false;
            C_matrix_dgv.AllowUserToAddRows = false;

            // Встановлюємо розміри сіток
            NUD_rozmir_ValueChanged(sender, e); // Викликаємо обробник для встановлення розміру 1

            // --- Новий код для ComboBox ---
            method_Selector_cmbx.Items.Add("Метод LU-перетворення"); // Index 0
            method_Selector_cmbx.Items.Add("Метод Гауса");           // Index 1
            method_Selector_cmbx.SelectedIndex = 0; // Встановлюємо LU як метод за замовчуванням

            // Встановлюємо видимість матриці С (вона потрібна для LU)
            UpdateCMatrixVisibility();
        }


        private void NUD_rozmir_ValueChanged(object sender, EventArgs e)
        {
            N = Convert.ToInt16(NUD_rozmir.Value);

            A_matrix_dgv.RowCount = N;
            A_matrix_dgv.ColumnCount = N;
            X_vector_dgv.RowCount = N;
            X_vector_dgv.ColumnCount = 1; // Вектори завжди мають 1 стовпець
            B_vector_dgv.RowCount = N;
            B_vector_dgv.ColumnCount = 1;
            C_matrix_dgv.RowCount = N;
            C_matrix_dgv.ColumnCount = N;
        }


        private void BCreateGrid_Click(object sender, EventArgs e)
        {
            bool exc_A = false;
            bool exc_B = false;

            // Зчитування матриці A
            for (i = 1; i <= N; i++)
            {
                for (j = 1; j <= N; j++)
                {
                    try
                    {
                        A[i, j] = Convert.ToDouble(A_matrix_dgv[j - 1, i - 1].Value);
                    }
                    catch
                    {
                        A_matrix_dgv[j - 1, i - 1].Style.ForeColor = Color.Red;
                        exc_A = true;
                    }
                }
            }

            // Зчитування вектору B
            for (j = 0; j < N; j++)
            {
                try
                {
                    B[j + 1] = Convert.ToDouble(B_vector_dgv[0, j].Value);
                }
                catch
                {
                    B_vector_dgv[0, j].Style.ForeColor = Color.Red;
                    exc_B = true;
                }
            }

            if (exc_A || exc_B)
            {
                MessageBox.Show("Помилка введення!");
                return;
            }


            if (method_Selector_cmbx.SelectedIndex == 0) // Метод LU
            {
                Decomp(N, ref Change);
                Solve(Change, N);
            }
            else // Метод Гауса
            {
                // Метод Гауса працює з A і B, і записує результат в X
                GaussSolve(N);
            }


            // Виведення розв'язку (вектор X)
            for (i = 0; i < N; i++)
            {
                X_vector_dgv[0, i].Value = X[i + 1].ToString();
            }
            MessageBox.Show("Розв'язок знайдено");
        }


        private void BClear_Click(object sender, EventArgs e)
        {
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    A_matrix_dgv[j, i].Value = "";
                    C_matrix_dgv[j, i].Value = "";
                }
            }
            for (j = 0; j < N; j++)
            {
                B_vector_dgv[0, j].Value = "";
                X_vector_dgv[0, j].Value = "";
            }
        }


        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void A_matrix_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            A_matrix_dgv.CurrentCell.Style.ForeColor = Color.Black;
        }


        private void B_vector_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            B_vector_dgv.CurrentCell.Style.ForeColor = Color.Black;
        }

        // Новий обробник для ComboBox
        private void method_Selector_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCMatrixVisibility();
        }

        // Допоміжний метод для оновлення UI
        private void UpdateCMatrixVisibility()
        {
            bool isLuMethod = (method_Selector_cmbx.SelectedIndex == 0);

            // "Матриця С" та її мітка потрібні лише для LU-методу
            C_matrix_dgv.Visible = isLuMethod;
            label5.Visible = isLuMethod; // label5 - це "Матриця С коефіцієнтів..."
        }


    }
}
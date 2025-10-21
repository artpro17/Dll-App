using ClassLibrary1;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из текстовых полей
                if (double.TryParse(txtMass.Text, out double mass) && 
                    double.TryParse(txtHeight.Text, out double height))
                {
                    // Проверяем, что значения больше нуля
                    if (mass >= 0 && height >= 0)
                    {
                        // Вызываем метод CalculateBMI из библиотеки ClassLibrary1
                        double bmi = ClassLibrary1.BMI.CalculateBMI(mass, height);
                        
                        // Выводим результат в текстовое поле ИМТ
                        txtBMI.Text = bmi.ToString("F2");
                    }
                    else
                    {
                        MessageBox.Show("Масса и рост должны быть больше нуля!", "Ошибка", 
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите корректные числовые значения для массы и роста!", 
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при расчете ИМТ: {ex.Message}", 
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
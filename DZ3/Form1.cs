using DZ3.Model;
namespace DZ3
{
    public partial class Form1 : Form
    {
        string[] query = new string[] { "всей информации из таблицы с овощами и фруктами",
                "всех названий овощей и фруктов", "всех цветов",
                "максимальную калорийность", "минимальную калорийность",
                "среднюю калорийность","количество овощей",
            "количество фруктов","количество овощей и фруктов заданного цвета",
                "количество овощей фруктов каждого цвета","овощи и фрукты с калорийностью ниже указанной",
            "овощи и фрукты с калорийностью выше указанной","овощи и фрукты с калорийностью в указанном диапазоне",
            "все овощи и фрукты, у которых цвет желтый или красный"};
        public Form1()
        {

            InitializeComponent();
            comboColor.Items.AddRange(new string[] { "красный", "зеленый", "желтый" });
            comboBoxQuery.Items.AddRange(query);
            comboBoxQuery.SelectedIndex = 0;
            comboColor.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            DBManager dBManager = new DBManager();
            VegetablesFruitsDBCLients vc = new VegetablesFruitsDBCLients(dBManager);
            try
            {
                switch (comboBoxQuery.SelectedIndex)
                {
                    case 0:
                        {
                            List<VegetablesFruits> fruits = vc.SelectAll();
                            outpuListBox(fruits);
                        }
                        break;
                    case 1:
                        {
                            List<string> strings = vc.SelectName();
                            outpuListBox(strings);
                        }
                        break;
                    case 2:
                        {
                            List<string> strings = vc.SelectColor();
                            outpuListBox(strings);
                        }
                        break;
                    case 3:
                        {
                            List<VegetablesFruits> fruits = vc.MAXCalorie();
                            outpuListBox(fruits);
                        }
                        break;
                    case 4:
                        {
                            List<VegetablesFruits> fruits = vc.MINCalorie();
                            outpuListBox(fruits);
                        }
                        break;
                    case 5:
                        {
                            List<string> strings = vc.SelectAVGCalorie();
                            outpuListBox(strings);
                        }
                        break;
                    case 6:
                        {
                            List<string> strings = vc.SelectCntCVegetable();
                            outpuListBox(strings);
                        }
                        break;
                    case 7:
                        {
                            List<string> strings = vc.SelectCntFruit();
                            outpuListBox(strings);
                        }
                        break;
                    case 8:
                        {
                            List<string> strings = vc.SelectCntFruitAndVegetable(comboColor.Text);
                            outpuListBox(strings);
                        }
                        break;
                    case 9:
                        {
                            List<string> strings = vc.SelectCntFruitAndVegetable();
                            outpuListBox(strings);
                        }
                        break;
                    case 10:
                        {
                            int number = 0;
                            if (!int.TryParse(textBoxMIN.Text, out number))
                            {
                                textBoxMIN.Text = "0";
                                MessageBox.Show("введите число", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            List<VegetablesFruits> fruits = vc.SelectLessCalories(number);
                            outpuListBox(fruits);
                            textBoxMIN.Text = "0";
                        }
                        break;
                    case 11:
                        {
                            int number = 0;
                            if (!int.TryParse(textBoxMAX.Text, out number))
                            {
                                textBoxMAX.Text = "100";
                                MessageBox.Show("введите число", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            List<VegetablesFruits> fruits = vc.SelectMoreCalories(number);
                            outpuListBox(fruits);
                            textBoxMAX.Text = "100";
                        }
                        break;
                    case 12:
                        {
                            int numberMin = 0;
                            int numberMax = 0;
                            if (!int.TryParse(textBoxMAX.Text, out numberMax) || !int.TryParse(textBoxMIN.Text, out numberMin) || numberMax < numberMin)
                            {
                                textBoxMIN.Text = "0";
                                textBoxMAX.Text = "100";
                                MessageBox.Show("введите число, min должно быть меньше max ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;

                            }
                            List<VegetablesFruits> fruits = vc.SelecteCalories(numberMin, numberMax);
                            outpuListBox(fruits);
                            textBoxMIN.Text = "0";
                            textBoxMAX.Text = "100";
                        }
                        break;
                    case 13:
                        {
                            List<VegetablesFruits> fruits = vc.SelectAllYEllowAndRed();
                            outpuListBox(fruits);
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void outpuListBox(List<VegetablesFruits> fruits)
        {
            listBox.Items.Add("0 -  наименование - тип - цвет - колорийность");
            foreach (var item in fruits)
            {
                listBox.Items.Add(item);
            }
        }
        private void outpuListBox(List<string> fruits)
        {
            foreach (var item in fruits)
            {
                listBox.Items.Add(item);
            }
        }
    }
}
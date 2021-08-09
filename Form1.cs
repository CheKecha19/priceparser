using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;

namespace priceparser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void find_button_1_Click(object sender, EventArgs e)
        {

        Start:
            //очищаем тело вывода текста
            richTextBox1.Text = null;
            

            //проверяем заполненность данных
            if (drop_link.Text == null || drop_name.Text == null || drop_price.Text == null || comboBox1.SelectedItem == null || coin.SelectedItem == null)
            {
                //если что то не заполено - увольте, ушиб очка
                MessageBox.Show("что то не заполнил, проверь\n\nнужно заполнить ссылку, имя, цену, валюту и тип товара");
            }
            else
            {
                //если всё заполнено, ебашим в переменные текст
                string Name = drop_name.Text;
                string Price = drop_price.Text;
                string Link = drop_link.Text;


                Ping pingSender = new Ping();
                PingOptions options = new PingOptions();


                {
                    //подтягивает код со страницы
                    WebClient wc = new WebClient();
                    string answer = wc.DownloadString(Link);
                    richTextBox1.AppendText(answer);
                }

                //проверка на батоны для выборки прайса
                if (LOE_button.Checked == true)
                {
                    int change = 0;
                }
                else if (MOE_button.Checked == true)
                {
                    int change = 1;
                }
                else
                {
                    int change = 2;
                }



                //прогресс обновления страницы
                //progress_obnovleniya_stranitsy.Value=1;


                //сохранение полученных данных в файл
                if(saver.Checked==true)
                {
                    string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                        "PriceLog",
                        "PriceLog.txt");

                    try
                    {
                        File.WriteAllLines(filepath, richTextBox1.Lines);
                    }
                    catch
                    {
                        
                    }
                }


                if (auto_check.Checked == true)
                {
                    //парсим время для автозапуска
                    int Vremya_Obnovleniya_Dannih = int.Parse(time_text.Text);
                    //время до следующего обновления данных
                    progress_obnovleniya_dannih.Value = Vremya_Obnovleniya_Dannih * 1000;
                    //спим Time секунд
                    Thread.Sleep(Vremya_Obnovleniya_Dannih * 1000);
                    // откат в начало кнопки
                    goto Start;
                    // макаронина, если чо, в начале кнопки
                }
            }

        }

    }
}

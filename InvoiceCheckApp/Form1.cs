using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace InvoiceCheckApp
{


    public partial class Form1 : Form
    {
        static Dictionary<string, Invoice> _DicOfAllInvoice;//所有期別獎項數據 <日期,各獎項號碼集合>
        static Dictionary<string, string> _DicOfThreeNumbersOfAllPrize = new Dictionary<string, string>();//各獎項之號碼後三碼
        static string CurrentChooseIntervalStr = "";//當前選擇之期別


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)//window load
        {
            ReturnInvoice _ReturnInvoice = new ReturnInvoice();
            _DicOfAllInvoice = _ReturnInvoice.GetInvoiceFromUrl();//從財政部取回中獎數據
            var IntervalList = _DicOfAllInvoice.Select(m => m.Key).ToList();

            OneBtn.Text = IntervalList[0];//最近一期日期標題
            SecondBtn.Text = IntervalList[1];//上一期日期標題
            ThirdBtn.Text = IntervalList[2];//上上期日期標題
            SelectInterval((object)OneBtn, null);//預設最近一期

        }


        private void SelectInterval(object sender, EventArgs e)
        {
            _DicOfThreeNumbersOfAllPrize.Clear();//清空當前選擇期數之各獎項號碼後３碼

            CurrentChooseIntervalStr = ((System.Windows.Forms.Button)sender).Text;

            var SelectIntervalOfAllPrize = from s in _DicOfAllInvoice　//取出當前選擇期數之各獎項號碼
                                           where s.Key == CurrentChooseIntervalStr
                                           select new { s.Value.VerySpecialPrize, s.Value.SpecialPrize, s.Value.JackPot, s.Value.SixthPrize };


            foreach (var PrizeNumber in SelectIntervalOfAllPrize)//將後3碼存入以供比對
            {
                _DicOfThreeNumbersOfAllPrize.Add(PrizeNumber.VerySpecialPrize, PrizeNumber.VerySpecialPrize.Substring(5));
                _DicOfThreeNumbersOfAllPrize.Add(PrizeNumber.SpecialPrize, PrizeNumber.SpecialPrize.Substring(5));
                foreach (var PrizeNumberOfJackPot in PrizeNumber.JackPot)
                {
                    _DicOfThreeNumbersOfAllPrize.Add(PrizeNumberOfJackPot, PrizeNumberOfJackPot.Substring(5));

                }
                foreach (var PrizeNumberOfSixthPrize in PrizeNumber.SixthPrize)
                {
                    _DicOfThreeNumbersOfAllPrize.Add(PrizeNumberOfSixthPrize, PrizeNumberOfSixthPrize);

                }


                LableOfCurrentInterval.Text = $"目前選擇期數:{CurrentChooseIntervalStr}";
                LabelOfVerySpecialPrize.Text = $"特別獎號碼:{PrizeNumber.VerySpecialPrize}";
                LabelOfSpecialPrize.Text = $"特獎號碼:" + PrizeNumber.SpecialPrize;
                LabelOfJackPot.Text = $"頭獎號碼:{String.Join("、", PrizeNumber.JackPot.ToArray())}";
                LabelOfSixthPrize.Text = $"六獎號碼:{String.Join("、", PrizeNumber.SixthPrize.ToArray())}";
                LablePrizeType.Text = "中獎資訊:";
                LablePrizeType.ForeColor = Color.Black;
                InputNumberBox.Focus();

            }


        }

        private void InputNumberBox_KeyPress(object sender, KeyPressEventArgs e)//only input number，限制只能輸入數字
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void InputNumberBox_TextChanged(object sender, EventArgs e)//NumberBoxChange事件檢測
        {
            if (InputNumberBox.Text.Length == 3)
            {
                var Query = _DicOfThreeNumbersOfAllPrize.Where(s => s.Value == InputNumberBox.Text).Select(m => m.Key).FirstOrDefault();//搜尋後3碼對應之中獎全碼
                CheckOfPrizeType(Query, InputNumberBox.Text);

                InputNumberBox.Text = "";
            }
        }

        private void CheckOfPrizeType(string _PrizeNumber, string _InputNumber)
        {
            var Query = _DicOfAllInvoice.Where(m => m.Key == CurrentChooseIntervalStr).FirstOrDefault();//取出當前選擇之期數之中獎號碼



            if (_PrizeNumber == Query.Value.VerySpecialPrize)
            {
                LablePrizeType.Text = $"注意:{_PrizeNumber}特別獎!8位數全中則1000萬元";
                LablePrizeType.ForeColor = Color.Red;

            }
            else if (_PrizeNumber == Query.Value.SpecialPrize)
            {
                LablePrizeType.Text = $"注意:{_PrizeNumber}特獎!8位數全中則200萬元";
                LablePrizeType.ForeColor = Color.Red;


            }
            else if (Query.Value.JackPot.Any(m => m == _PrizeNumber))
            {
                string number = Query.Value.JackPot.Where(m => m == _PrizeNumber).FirstOrDefault();
                LablePrizeType.Text = $"中獎!頭獎號碼:{number}中200元或五獎~頭獎";
                LablePrizeType.ForeColor = Color.Red;


            }
            else if (Query.Value.SixthPrize.Any(m => m == _PrizeNumber))
            {
                string number = Query.Value.SixthPrize.Where(m => m == _PrizeNumber).FirstOrDefault();
                LablePrizeType.Text = $"中獎!六獎號碼:{number}中200元";
                LablePrizeType.ForeColor = Color.Red;

            }
            else
            {
                LablePrizeType.Text = $"可惜，號碼{_InputNumber}未中獎";
                LablePrizeType.ForeColor = Color.Blue;

            }

        }



    }



}

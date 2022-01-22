using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;

namespace InvoiceCheckApp
{
    class Invoice
    {
        public string VerySpecialPrize;
        public string SpecialPrize;
        public List<string> JackPot;
        public List<string> SixthPrize;


        public string ReplaceLabelP(string str, string head)
        {
            return str.Replace("<p>", "").Replace("</p>", "").Replace(head, "");
        }
    }
    class ReturnInvoice
    {
        public Dictionary<string, Invoice> GetInvoiceFromUrl()
        {
            Dictionary<string, Invoice> Dic_Invoice = new Dictionary<string, Invoice>();

            String URLString = "https://invoice.etax.nat.gov.tw/invoice.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(URLString);


            XmlNode _rootnode = xmlDoc.SelectSingleNode("rss");
            XmlNodeList xnlA = _rootnode.ChildNodes;

            foreach (XmlNode xnA in xnlA)//遍歷rss底下的屬性
            {
                XmlElement xeB = (XmlElement)xnA;
                XmlNodeList xnlB = xeB.ChildNodes;

                foreach (XmlNode xnB in xnlB)//遍歷channel底下的屬性
                {
                    XmlElement xeC = (XmlElement)xnB;

                    if (xeC.Name == "item")
                    {
                        XmlNodeList xnlC = xeC.ChildNodes;
                        Invoice _invoice = new Invoice();

                        string date = "";

                        foreach (XmlNode xnC in xnlC)//遍歷item底下的屬性
                        {
                            XmlElement xeD = (XmlElement)xnC;
                            switch (xeD.Name)
                            {
                                case "title":
                                    Console.WriteLine("期別:" + xeD.InnerText);
                                    date = xeD.InnerText;
                                    break;

                                case "description":
                                    string pattern = @"<p>.*?<\/p>";

                                    Regex regex = new Regex(pattern);
                                    MatchCollection _matchList = regex.Matches(xeD.InnerText);
                                    foreach (var matchItem in _matchList)
                                    {

                                        Console.WriteLine(matchItem.ToString().Replace("<p>", "").Replace("</p>", ""));


                                        if (matchItem.ToString().Contains("特別獎"))
                                        {
                                            _invoice.VerySpecialPrize = _invoice.ReplaceLabelP(matchItem.ToString(), "特別獎：");
                                        }
                                        else if (matchItem.ToString().Contains("特獎"))
                                        {
                                            _invoice.SpecialPrize = _invoice.ReplaceLabelP(matchItem.ToString(), "特獎：");
                                        }
                                        else if (matchItem.ToString().Contains("頭獎"))
                                        {
                                            _invoice.JackPot = new List<string>();
                                            foreach (var item in _invoice.ReplaceLabelP(matchItem.ToString(), "頭獎：").Split('、'))
                                            {
                                                _invoice.JackPot.Add(item);
                                            }

                                        }
                                        else if (matchItem.ToString().Contains("增開六獎"))
                                        {
                                            _invoice.SixthPrize = new List<string>();
                                            foreach (var item in _invoice.ReplaceLabelP(matchItem.ToString(), "增開六獎：").Split('、'))
                                            {
                                                _invoice.SixthPrize.Add(item);
                                            }

                                        }


                                    }

                                    Console.WriteLine();
                                    break;
                                default:
                                    break;
                            }

                        }
                        Dic_Invoice.Add(date, _invoice);

                    }



                }
            }

            return Dic_Invoice;
        }


    }
}

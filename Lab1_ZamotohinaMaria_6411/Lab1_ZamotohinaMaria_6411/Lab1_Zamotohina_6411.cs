using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab1_ZamotohinaMaria_6411
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class HaffamanNode
        {
            public double Probability { set; get; }
            public HaffamanNode Left { set; get; }
            public HaffamanNode Right { set; get; } 
            public string Code { set; get; }
            public string Symbols { set; get; }
        }


        private Dictionary<char, double> CalculateSortProbabilities(string text)
        {
            var probabilities = new Dictionary<char, double>();

            //Посчитали количество вхождения каждого символа в строку
            foreach (var symbol in text)
            {
                if (probabilities.ContainsKey(symbol) == true)
                    probabilities[symbol] += 1;
                else
                    probabilities.Add(symbol, 1);
            }


            foreach (var symbol in probabilities.Keys.ToList())
            {
                probabilities[symbol] /= text.Length;
            }

            return probabilities.OrderByDescending(p => p.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        private void btn_CodingHaffman(object sender, EventArgs e)
        {
            string text = textBoxHaffmanFIO.Text;
            text = text.ToLower();
            textBoxHaffmanFIO.Text = "";

            var probabilities = CalculateSortProbabilities(text);


            foreach (var symbol in probabilities.Keys.ToList())
            {
                probabilitiesHaffman.AppendText($"{symbol} - {probabilities[symbol]}\n");
            }
            probabilitiesHaffman.AppendText($"\nСумма вероятностей = {probabilities.Sum(p => p.Value)}");

            var symbols = probabilities.Keys.ToList();
            var code = new Dictionary<char, string>();
            foreach (var symbol in symbols)
                code.Add(symbol, "");

            var root = MakeHaffmanTree(probabilities);
            var codingText = CodingByHaffmanTree(root, text);

            statisticHaffman.Text = $"Объем строки: {text.Length} байт\r\n" +
                $"Объем закодированной строки: {Convert.ToDouble(codingText.Length) / 8} байт\r\n" +
                $"Сжатие: {100 - Convert.ToDouble(codingText.Length) / (8 * Convert.ToDouble(text.Length)) * 100}%";

        }

        private HaffamanNode MakeHaffmanTree(Dictionary<char, double> probabilities)
        {
            probabilities = probabilities.Reverse().ToDictionary(x => x.Key, x => x.Value);
            var symbols = probabilities.Keys.ToList();
            List<HaffamanNode> haffmanSteck = new List<HaffamanNode>();

            foreach (var symbol in symbols)
            {
                haffmanSteck.Add(new HaffamanNode { Probability = probabilities[symbol], Left = null, Right = null, Code = "" , Symbols = symbol.ToString()});
            }

            HaffamanNode root = null;

            int i = 0;

            while (true)
            {
                if (haffmanSteck[i].Probability >= haffmanSteck[i + 1].Probability && haffmanSteck[i].Probability / haffmanSteck[i + 1].Probability <= 2)
                {
                    haffmanSteck[i].Code = "1" + haffmanSteck[i].Code;
                    haffmanSteck[i + 1].Code = "0" + haffmanSteck[i + 1].Code;
                    var node = new HaffamanNode { Probability = haffmanSteck[i].Probability + haffmanSteck[i + 1].Probability, Left = haffmanSteck[i + 1], Right = haffmanSteck[i], Code = "", Symbols = haffmanSteck[i].Symbols + haffmanSteck[i + 1].Symbols };
                    haffmanSteck.RemoveAt(i);
                    haffmanSteck.RemoveAt(i);
                    haffmanSteck.Insert(i, node);
                    if (i >= 1)
                        i--;
                    else
                        root = node;
                    continue;
                }
                if (haffmanSteck[i].Probability <= haffmanSteck[i + 1].Probability && haffmanSteck[i + 1].Probability / haffmanSteck[i].Probability <= 2)
                {
                    haffmanSteck[i].Code = "0" + haffmanSteck[i].Code;
                    haffmanSteck[i + 1].Code = "1" + haffmanSteck[i + 1].Code;
                    var node = new HaffamanNode { Probability = haffmanSteck[i].Probability + haffmanSteck[i + 1].Probability, Left = haffmanSteck[i + 1], Right = haffmanSteck[i], Code = "", Symbols = haffmanSteck[i].Symbols + haffmanSteck[i + 1].Symbols };
                    haffmanSteck.RemoveAt(i);
                    haffmanSteck.RemoveAt(i);
                    haffmanSteck.Insert(i, node);
                    if (i >= 1) 
                        i--;
                    else
                        root = node;
                    continue;
                }
                if (haffmanSteck.Count == 2)
                {
                    haffmanSteck[0].Code = "1" + haffmanSteck[0].Code;
                    haffmanSteck[1].Code = "0" + haffmanSteck[1].Code;
                    var node = new HaffamanNode { Probability = haffmanSteck[0].Probability + haffmanSteck[1].Probability, Left = haffmanSteck[1], Right = haffmanSteck[0], Code = "", Symbols = haffmanSteck[0].Symbols + haffmanSteck[1].Symbols};
                    haffmanSteck.RemoveAt(0);
                    haffmanSteck.RemoveAt(0);
                    haffmanSteck.Insert(0, node);
                    root = node;
                    break;
                }
                else
                {
                    i++;
                }
            }
            return root;
        }

        private string CodingByHaffmanTree(HaffamanNode root, string text)
        {
            string result = string.Empty;

            foreach(var symbol in text)
            {
                string symbolCode = string.Empty;
                HaffamanNode start = root;
                while (true)
                {
                    if (start.Symbols == symbol.ToString()) break;
                    if (start.Left.Symbols.Contains(symbol) == true)
                    {
                        symbolCode += start.Left.Code;
                        start = start.Left;
                    }
                    else
                    {
                        symbolCode += start.Right.Code;
                        start = start.Right;
                    }
                }
                result += symbolCode;
            }

            return result;
        }
       
        private void btn_CodingShennonFanno(object sender, EventArgs e)
        {
            string text = textBoxShennonFIO.Text;
            text = text.ToLower();
            textBoxShennonFIO.Text = "";

            var probabilities = CalculateSortProbabilities(text);

            foreach (var symbol in probabilities.Keys.ToList())
            {
                probabilitiesShennon.AppendText($"{symbol} - {probabilities[symbol]}\n");
            }
            probabilitiesShennon.AppendText($"\nСумма вероятностей = {probabilities.Sum(p => p.Value)}");

            var symbols = probabilities.Keys.ToList();
            var code = new Dictionary<char, string>();
            foreach (var symbol in symbols)
                code.Add(symbol, "");

            ShennonFanno(symbols, probabilities, code, "");

            string codingText = string.Empty;
            foreach (var symbol in text)
            {
                codingText += code[symbol];
            }

            textBoxShennonCode.Text = codingText;
            statisticShennon.Text = $"Объем строки: {text.Length} байт\r\n" +
                $"Объем закодированной строки: {Convert.ToDouble(codingText.Length) / 8} байт\r\n" +
                $"Сжатие: {100 - Convert.ToDouble(codingText.Length) / (8 * Convert.ToDouble(text.Length)) * 100}%";
        }

        private void ShennonFanno(List<char> symbols, Dictionary<char, double> probabilities, Dictionary<char, string> codes, string postfix)
        {
            if (symbols.Count == 1)
            {
                codes[symbols[0]] = postfix;
                return;
            }

            double fullProbability = symbols.Sum(s => probabilities[s]);
            double cumulativeProbability = 0;
            int splitIndex = 0;

            for (int i = 0; i < symbols.Count; i++)
            {
                cumulativeProbability += probabilities[symbols[i]];
                if (cumulativeProbability >= fullProbability / 2)
                {
                    splitIndex = i;
                    break;
                }
            }

            ShennonFanno(symbols.Take(splitIndex + 1).ToList(), probabilities, codes, postfix + "0");
            ShennonFanno(symbols.Skip(splitIndex + 1).ToList(), probabilities, codes, postfix + "1");
        }

        private void btn_CodeArithmetic(object sender, EventArgs e)
        {
            string text = textBoxArithmeticFIO.Text;
            text = text.ToLower();
            textBoxHaffmanFIO.Text = "";

            var probabilities = CalculateSortProbabilities(text);

            var intervals = new Dictionary<char, List<double>>();

            double start = 0;

            foreach (var key in probabilities.Keys)
            {
                intervals.Add(key, new List<double>() { start, start + probabilities[key] });
                start += probabilities[key];
            }

            double min = 0;
            double max = 1;

            foreach (var key in text)
            {
                var delta = max - min;
                max = min + delta*intervals[key][1];
                min = min + delta*intervals[key][0];
            }

            var codingText = ((max + min) / 2.0).ToString();

            codingText = codingText.Split(',')[1];
            var binaryCode = Convert.ToString(long.Parse(codingText), 2);
            textBoxArithmeticCode.Text = $"{codingText}\r\n{binaryCode}";

            statisticArithmetic.Text = $"Объем строки: {text.Length} байт\r\n" +
                $"Объем закодированной строки: {codingText.Length} байт\r\n" +
                $"Сжатие: {100 - Convert.ToDouble(codingText.Length) / (Convert.ToDouble(text.Length)) * 100}%";

        }
        
        private void btn_DecodingShennonFanno(object sender, EventArgs e)
        {

        }

        private void btn_DecodingHaffman(object sender, EventArgs e)
        {

        }


        private void btn_DecodeArithmetic(object sender, EventArgs e)
        {

        }
    }
}

/* Ethan Shipston
 * ICS4U
 * June 17, 2019
 * A program which finds the largest palindrome that can be formed with three digit multiples.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _184988LargestPalindromeProduct
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int big = 0;
        int counter = 0;
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 1; i < 1000; i++)
            {
                for (int ii = 1; ii < 1000; ii++)
                {
                    int temp = i * ii;
                    for (int iii = 0; iii <= temp.ToString().Length / 2; iii++)
                    {
                        if (temp.ToString().Length == 1)
                        {
                            if (temp > big)
                                big = temp;
                        }
                        else
                        {
                            string tempstring = temp.ToString();
                            string start = tempstring.Substring(iii, 1);
                            string end = tempstring.Substring(tempstring.Length - 1 - iii, 1);
                            if (start == end)
                            {
                                if (iii == temp.ToString().Length / 2)
                                {
                                    if (temp > big)
                                        big = temp;
                                }
                            }
                            else
                                iii = temp.ToString().Length;
                        }
                        
                    }
                }
            }
            MessageBox.Show(big.ToString());
        }
    }
}

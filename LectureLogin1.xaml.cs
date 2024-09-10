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
using System.Windows.Shapes;

namespace ContractSystemClaimSystem3
{
    public partial class LectureLogin1 : Window
    {
        public LectureLogin1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // For now, we assume the login is always successful
            LectureDetails1 lectureDetails1 = new LectureDetails1();
            lectureDetails1.Show();
            this.Close(); // Close the login window
        }
    }
}
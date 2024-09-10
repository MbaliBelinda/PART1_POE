using Microsoft.Win32; // For OpenFileDialog
using System;
using System.IO; // For file operations
using System.Windows;


namespace ContractSystemClaimSystem3
{
   
    public partial class LectureDetails1 : Window
    {
        public LectureDetails1()
        {
            InitializeComponent();
        }

        // Back Button click event handler
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the Lecture Details window and go back to the previous window
            this.Close();
        }

        // Next Button click event handler
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            // Perform actions such as data validation or saving entered details
            // Navigate to the next form (e.g., AddClaims window)
            AddClaims1 addClaims1Window = new AddClaims1();
            addClaims1Window.Show();
            this.Close(); // Optionally close the current window if not needed after navigation
        }
        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create an OpenFileDialog instance
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Set properties for the dialog
                openFileDialog.Filter = "All Files (*.*)|*.*"; // Allow all file types
                openFileDialog.Multiselect = true; // Allow multiple file selection
                openFileDialog.Title = "Select Files to Upload";

                // Show the dialog and check if the user selected files
                bool? result = openFileDialog.ShowDialog();

                if (result == true)
                {
                    // Get the selected file paths
                    string[] filePaths = openFileDialog.FileNames;

                    // Display selected file names
                    string fileList = string.Join(", ", filePaths);
                    MessageBox.Show($"Selected files:\n{fileList}", "File Selection", MessageBoxButton.OK, MessageBoxImage.Information);

                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}


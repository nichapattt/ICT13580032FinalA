using System;
using System.Collections.Generic;
using ICT13580032FinalA.Models;
using Xamarin.Forms;

namespace ICT13580032FinalA
{
    public partial class StatusNewPage : ContentPage
    {
        Status status;

        public StatusNewPage(Status status=null)
        {
            InitializeComponent();

            this.status = status;

            TitleLabel.Text = status == null ? "เพิ่มข้อมูล" : "แก้ไขข้อมูล";

            saveButton.Clicked += SaveButton_Clicked;
            cancleButton.Clicked += CancleButton_Clicked;

            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");

            divisionPicker.Items.Add("แผนกการตลาด");
            divisionPicker.Items.Add("แผนกการบัญชี");
            divisionPicker.Items.Add("แผนกการเงิน");

            statusMarryPicker.Items.Add("โสด");
            statusMarryPicker.Items.Add("สมรส");

            if(status != null)
            {
                firstNameEntry.Text = status.Firstname;
                lastNameEntry.Text = status.LastName;
                ageEntry.Text = status.Age.ToString();
                genderPicker.SelectedItem = status.Gender;
                divisionPicker.SelectedItem = status.Division;
                phoneEntry.Text = status.Phone.ToString();
                mailEntry.Text = status.Mail;
                addressEntry.Text = status.Address;
                statusMarryPicker.SelectedItem = status.StatusMarry;
                childenEntry.Text = status.Childen.ToString();
                salaryEntry.Text = status.Salary.ToString();

            }
        }

        async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var isOK = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่", "ไม่ใช่");
            if(isOK)
            {
                if (status == null)
                {

                    status = new Status();
                    status.Firstname = firstNameEntry.Text;
                    status.LastName = lastNameEntry.Text;
                    status.Age = int.Parse(ageEntry.Text);
                    status.Gender = genderPicker.SelectedItem.ToString();
                    status.Division = divisionPicker.SelectedItem.ToString();
                    status.Phone = int.Parse(phoneEntry.Text);
                    status.Mail = mailEntry.Text;
                    status.Address = addressEntry.Text;
                    status.StatusMarry = statusMarryPicker.SelectedItem.ToString();
                    status.Childen = int.Parse(childenEntry.Text);
                    status.Salary = decimal.Parse(salaryEntry.Text);
                    var firstName = App.DbHelper.AddStatus(status);
                    await DisplayAlert("บันทึกสำเร็จ", "ชื่อของท่านคือ" + firstName, "ตกลง");
                }
                else
                {
					status.Firstname = firstNameEntry.Text;
					status.LastName = lastNameEntry.Text;
					status.Age = int.Parse(ageEntry.Text);
					status.Gender = genderPicker.SelectedItem.ToString();
					status.Division = divisionPicker.SelectedItem.ToString();
					status.Phone = int.Parse(phoneEntry.Text);
					status.Mail = mailEntry.Text;
					status.Address = addressEntry.Text;
					status.StatusMarry = statusMarryPicker.SelectedItem.ToString();
					status.Childen = int.Parse(childenEntry.Text);
					status.Salary = decimal.Parse(salaryEntry.Text);
                    var firstName = App.DbHelper.UpdateStatus(status);
					await DisplayAlert("บันทึกสำเร็จ", "แก้ไขข้อมูลของท่านเรียบร้อย", "ตกลง");
                }
                await Navigation.PopModalAsync();
            }
        }

        void CancleButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}

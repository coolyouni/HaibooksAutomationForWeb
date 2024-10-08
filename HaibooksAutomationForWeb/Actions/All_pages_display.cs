﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HaibooksAutomationForWeb.Constant;
using HaibooksAutomationForWeb.TestCases;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HaibooksAutomationForWeb.Elements
{
    public partial class system_elements : Baseclass
    {
        int row_size; int Disposed_assets_count_value;


        public void verify_Dashboard_page_display()
        {
            //Verifying All Dashboard stuff
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //Verify sales link

            bool financial_overview_view_sales_link_showing, financial_overview_view_purchase_link_showing, financial_overview_view_Taxes_link_showing, financial_overview_view_profit_link_showing, create_new_dashboard_showing, create_new_invoice_dashboard_showing, create_new_bill_dashboard_showing, create_new_expenses_dashboard_1_showing, create_new_Mileage_dashboard_1_showing, create_new_contact_dashboard_showing, financial_overivew_Fiscal_year_showing, financial_overivew_six_months_showing, financial_overivew_This_month_showing;
            try
            {
                waitformee.Until(driver => _systemElements1.financial_overview_view_sales_link.Displayed);
                financial_overview_view_sales_link_showing = true;
            }
            catch (Exception e)
            {
                //Console.WriteLine("financial_overview_view_sales_link_showing is fail");
                financial_overview_view_sales_link_showing = false;
            }

            try
            {
                waitformee.Until(driver => _systemElements1.financial_overview_view_purchase_link.Displayed);
                financial_overview_view_purchase_link_showing = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(" financial_overview_view_purchase_link_showing = false");
                financial_overview_view_purchase_link_showing = false;
            }
            try
            {
                waitformee.Until(driver => _systemElements1.financial_overview_view_Taxes_link.Displayed);
                financial_overview_view_Taxes_link_showing = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("financial_overview_view_Taxes_link_showing = false");
                financial_overview_view_Taxes_link_showing = false;
            }

            try
            {
                waitformee.Until(driver => _systemElements1.financial_overview_view_profit_link.Displayed);
                financial_overview_view_profit_link_showing = true;
            }
            catch (Exception e)
            {
                financial_overview_view_profit_link_showing = false;
                Console.WriteLine("financial_overview_view_profit_link_showing = false");
            }

            try
            {
                waitformee.Until(driver => _systemElements1.create_new_dashboard.Displayed);
                create_new_dashboard_showing = true;
                _systemElements1.create_new_dashboard.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("create_new_dashboard_showing = false");
                create_new_dashboard_showing = false;
            }           

            try
            {
                waitformee.Until(driver => _systemElements1.create_new_invoice_dashboard.Displayed);
                create_new_invoice_dashboard_showing = true;
            }
            catch (Exception e)
            {
                create_new_invoice_dashboard_showing = false;
                Console.WriteLine("create_new_invoice_dashboard_showing = false");
            }

            try
            {
                waitformee.Until(driver => _systemElements1.create_new_bill_dashboard.Displayed);
                create_new_bill_dashboard_showing = true;
            }
            catch (Exception e)
            {
                create_new_bill_dashboard_showing = false;
                Console.WriteLine("create_new_bill_dashboard_showing = false");
            }

            try
            {
                waitformee.Until(driver => _systemElements1.create_new_expenses_dashboard_1.Displayed);
                create_new_expenses_dashboard_1_showing = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("create_new_expenses_dashboard_1_showing=false");
                create_new_expenses_dashboard_1_showing = false;
            }

            try
            {
                waitformee.Until(driver => _systemElements1.create_new_Mileage_dashboard_1.Displayed);
                create_new_Mileage_dashboard_1_showing = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("create_new_Mileage_dashboard_1_showing=false");
                create_new_Mileage_dashboard_1_showing = false;
            }

            try
            {
                waitformee.Until(driver => _systemElements1.create_new_contact_dashboard.Displayed);
                create_new_contact_dashboard_showing = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("create_new_contact_dashboard_showing = False");
                create_new_contact_dashboard_showing = false;
            }

            waitformee.Until(ExpectedConditions.ElementToBeClickable(_systemElements1.create_new_dashboard));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.create_new_dashboard);
           // _systemElements1.create_new_dashboard.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            try
            {
                _systemElements1.financial_overivew_Fiscal_year.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                financial_overivew_Fiscal_year_showing = true;
            }
            catch (Exception e) 
            { 
                Console.WriteLine("financial_overivew_Fiscal_year is not showing");
                financial_overivew_Fiscal_year_showing = false;
            }
            try
            {
                waitformee.Until(driver => _systemElements1.financial_overivew_six_months.Displayed);
                financial_overivew_six_months_showing = true;
            }
            catch (Exception e) 
            { 
                Console.WriteLine("financial_overivew_six_months is not showing");
                financial_overivew_six_months_showing = false;
            }
            try
            {
                waitformee.Until(driver => _systemElements1.financial_overivew_This_month.Displayed);
                financial_overivew_This_month_showing = true;
            }
            catch (Exception e) {
                Console.WriteLine("financial_overivew_This_month is not showing");
                financial_overivew_This_month_showing = false;
            }

            try
            {
                _systemElements1.financial_overivew_Fiscal_year.Click();
                financial_overivew_Fiscal_year_showing = true;

            }
            catch (Exception e) {
                Console.WriteLine("financial_overivew_Fiscal_year_showing fail");
                financial_overivew_Fiscal_year_showing = false;
            }
        }

        public void verify_Dashboard_data_display()
        {

            /////////////////////////////////////////////Data in sales////////////////////////////////////////////////////////
            ///

            bool sales_pie_chart_containter_showing, sales_Fiscal_year_shoiwng, sales_six_months_show, sales_This_month_show, sales_pie_chart_paid_showing, sales_pie_chart_unpaid_showing, sales_pie_chart_overdue_show, purchase_pie_chart_containter_showing, purchase_Fiscal_year_show,
            purchase_six_months_show, purchase_This_month_show, purchase_pie_chart_paid_show, purchase_pie_chart_unpaid_show, purchase_pie_chart_overdue_show, Expenses_pie_chart_containter_show, Expenses_Fiscal_year_show, Expenses_six_months_show,
           Expenses_This_month_show, Expenses_pie_chart_MileageExpense_show, Expenses_pie_chart_purchases_show, Expenses_pie_chart_Other, connect_new_account_show, show_all_show;

            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            try
            {
                waitformee.Until(driver => _systemElements1.sales_pie_chart_containter.Displayed);
                sales_pie_chart_containter_showing = true;

            }
            catch (Exception e) { Console.WriteLine(" sales_pie_chart_containter_showing = false"); sales_pie_chart_containter_showing = false; }

            try
            {
                _systemElements1.sales_Fiscal_year.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                sales_Fiscal_year_shoiwng = true;
            }
            catch (Exception e) { Console.WriteLine("sales_Fiscal_year_shoiwng=false"); sales_Fiscal_year_shoiwng = false; }

            try
            {
                waitformee.Until(driver => _systemElements1.sales_six_months.Displayed);
                sales_six_months_show = true;
            }
            catch (Exception e) { Console.WriteLine("sales_six_months_show=false"); sales_six_months_show = false; }

            try
            {
                waitformee.Until(driver => _systemElements1.sales_This_month.Displayed);
                sales_This_month_show = true;
            }
            catch (Exception e) { Console.WriteLine("sales_This_month_show=false"); sales_This_month_show = false; }


            //Data in sales for status
            try
            {
                waitformee.Until(driver => _systemElements1.sales_pie_chart_paid.Displayed);
                sales_pie_chart_paid_showing = true;
            }
            catch (Exception e) { Console.WriteLine("sales_pie_chart_paid_showing=false"); sales_pie_chart_paid_showing = false; }


            try
            {
                waitformee.Until(driver => _systemElements1.sales_pie_chart_unpaid.Displayed);
                sales_pie_chart_unpaid_showing = true;
            }
            catch (Exception e) { Console.WriteLine("sales_pie_chart_unpaid_showing=false"); sales_pie_chart_unpaid_showing = false; }

            try
            {
                waitformee.Until(driver => _systemElements1.sales_pie_chart_overdue.Displayed);
                sales_pie_chart_overdue_show = true;
            }
            catch (Exception e) { Console.WriteLine("sales_pie_chart_overdue_show=false"); sales_pie_chart_overdue_show = false; }


            ////////////////////////////////////////////////////////////////////Data in Purchases//////////////////////////////////////////
            ///

            try
            {
                _systemElements1.purchase_pie_chart_containter.Click();
                purchase_pie_chart_containter_showing = true;
            }
            catch (Exception e) { Console.WriteLine("purchase_pie_chart_containter_showing=false"); purchase_pie_chart_containter_showing = false; }


            try
            {
                _systemElements1.purchase_Fiscal_year.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                purchase_Fiscal_year_show = true;
            }
            catch (Exception e) { Console.WriteLine("purchase_Fiscal_year_show=false"); purchase_Fiscal_year_show = false; }

            try
            {
                waitformee.Until(driver => _systemElements1.purchase_six_months.Displayed);
                purchase_six_months_show = true;
            }
            catch (Exception e) { Console.WriteLine("purchase_six_months_show=false"); purchase_six_months_show = false; }

            try
            {
                waitformee.Until(driver => _systemElements1.purchase_This_month.Displayed);
                purchase_This_month_show = true;
            }
            catch (Exception e) { Console.WriteLine("purchase_This_month_show=false");
                purchase_This_month_show = false;
            }
            try
            {
                waitformee.Until(driver => _systemElements1.purchase_pie_chart_paid.Displayed);
                purchase_pie_chart_paid_show = true;
            }
            catch (Exception e) { Console.WriteLine(" purchase_pie_chart_paid_show = false"); purchase_pie_chart_paid_show = false; }

            try
            {
                waitformee.Until(driver => _systemElements1.purchase_pie_chart_unpaid.Displayed);
                purchase_pie_chart_unpaid_show = true;
            }
            catch (Exception e) { Console.WriteLine("purchase_pie_chart_unpaid_show=false"); purchase_pie_chart_unpaid_show = false; }
            try
            {
                waitformee.Until(driver => _systemElements1.purchase_pie_chart_overdue.Displayed);
                purchase_pie_chart_overdue_show = true;
            }
            catch (Exception e) { Console.WriteLine("purchase_pie_chart_overdue_show=false"); purchase_pie_chart_overdue_show = false; }


            /////////////////////////////////////////////////////Expenses data

            try
            {
                _systemElements1.Expenses_pie_chart_containter.Click();
                Expenses_pie_chart_containter_show = true;
            }
            catch (Exception e) { Console.WriteLine("Expenses_pie_chart_containter_show=false"); Expenses_pie_chart_containter_show = false; }

            try
            {
                _systemElements1.Expenses_Fiscal_year.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                Expenses_Fiscal_year_show = true;
            }
            catch (Exception e) { Console.WriteLine("Expenses_Fiscal_year_show=false");
                Expenses_Fiscal_year_show = false;
            }
            try
            {
                waitformee.Until(driver => _systemElements1.Expenses_six_months.Displayed);
                Expenses_six_months_show = true;
            }
            catch (Exception e) { Console.WriteLine("Expenses_six_months_show=false"); Expenses_six_months_show = false; }

            try
            {
                waitformee.Until(driver => _systemElements1.Expenses_This_month.Displayed);
                Expenses_This_month_show = true;
            }
            catch (Exception e) { Console.WriteLine("Expenses_This_month=false"); Expenses_This_month_show = false; }


            try
            {
                waitformee.Until(driver => _systemElements1.Expenses_pie_chart_MileageExpense.Displayed);
                Expenses_pie_chart_MileageExpense_show = true;
            }
            catch (Exception e) { Console.WriteLine("Expenses_pie_chart_MileageExpense_show=false"); Expenses_pie_chart_MileageExpense_show = false; }
            try
            {
                waitformee.Until(driver => _systemElements1.Expenses_pie_chart_purchases.Displayed);
                Expenses_pie_chart_purchases_show = true;
            }
            catch (Exception e) { Console.WriteLine("Expenses_pie_chart_purchases_show=false"); Expenses_pie_chart_purchases_show = false; }
            try
            {
                waitformee.Until(driver => _systemElements1.Expenses_pie_chart_Other.Displayed);
                Expenses_pie_chart_Other = true;
            }
            catch (Exception e) { Console.WriteLine("Expenses_pie_chart_Other=false"); Expenses_pie_chart_Other = false; }


            try
            {
                waitformee.Until(driver => _systemElements1.connect_new_account.Displayed);
                connect_new_account_show = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("connect_new_account_show = false");
                connect_new_account_show = false;
            }


            try
            {
                waitformee.Until(driver => _systemElements1.show_all.Displayed);
                show_all_show = true;
            }
            catch (Exception e)
            {

                Console.WriteLine("show_all_show= false");
                show_all_show = false;
            }
        }

        public void verify_contact_page_display()
        {

            bool inactive_count_number_showing, active_count_number_showing, All_contact_tab_d, All_suppliers_tab_d, Groups_drop_down_d;
            //contacts page verification

            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            _systemElements1.contacts_leftmenu.Click();
            waitformee.Until(driver => _systemElements1.create_new_contact.Displayed);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            bool display_page_size = _systemElements1.page_size_display();
            if (display_page_size == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();
            }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            waitformee.Until(driver => _systemElements1.Active_contacts_count.Displayed);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            string active_count_number = _systemElements1.Active_contacts_count.Text;
            int active_count = Convert.ToInt32(active_count_number);
            _systemElements1.no_of_col_and_rows(Constants.contact_col, Constants.contact_rows);
            int column_size = _systemElements1.global_col;
            row_size = _systemElements1.global_row;
            if (active_count == row_size - 1)
            {
                Console.WriteLine("Showing all records for Active Contact:" + active_count_number);
                active_count_number_showing = true;
            }
            else
            {
                Console.WriteLine("fail" + active_count_number);
                active_count_number_showing = false;
            }

            //Inactive count
            Thread.Sleep(TimeSpan.FromSeconds(4));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.inActive_contacts);

            //waitformee.Until(ExpectedConditions.ElementToBeClickable(_systemElements1.inActive_contacts));
            //_systemElements1.inActive_contacts_count.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            bool display_page_sizes = _systemElements1.page_size_display();
            if (display_page_sizes == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();
            }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            string inactive_count_number = _systemElements1.inActive_contacts_count.Text;
            int inactive_count = Convert.ToInt32(inactive_count_number);
            int column_size_inactive, row_size_inactive = 0;
            if (inactive_count != 0)
            {
                _systemElements1.no_of_col_and_rows(Constants.contact_col, Constants.contact_rows);
                column_size_inactive = _systemElements1.global_col;
                row_size_inactive = _systemElements1.global_row;
                if (inactive_count == row_size_inactive - 1)
                {
                    Console.WriteLine("Showing all records for count:" + inactive_count_number);
                    inactive_count_number_showing = true;
                }
                else
                {
                    Assert.Fail("Fail inactive" + inactive_count_number);
                    inactive_count_number_showing = false;
                }
            }



            Thread.Sleep(TimeSpan.FromSeconds(1));
            try
            {
                waitformee.Until(driver => _systemElements1.All_contact_tab.Displayed);
                All_contact_tab_d = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("no fsa exists");
                All_contact_tab_d = false;
            }

            try
            {
                waitformee.Until(driver => _systemElements1.All_suppliers_tab.Displayed);
                All_suppliers_tab_d = true;
            }
            catch (Exception e)
            {

                Console.WriteLine("no werew exists");
                 All_suppliers_tab_d = false;
            }

            try
            {
                waitformee.Until(driver => _systemElements1.Groups_drop_down.Displayed);
                Groups_drop_down_d = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("no Groups_drop_down_d not exists");
                Groups_drop_down_d = false;
            }

        }

        public void verify_sales_invoices_page_display()
        {

            //Sales
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            waitformee.Until(driver => _systemElements1.sales_left_side.Displayed);
            if (_systemElements1.sales_left_side.GetAttribute("aria-expanded") == "false")
            {
                _systemElements1.sales_left_side.Click();
            }
            waitformee.Until(driver => _systemElements1.invoices_left_side.Displayed);
            _systemElements1.invoices_left_side.Click();
            waitformee.Until(driver => _systemElements1.ALL_INVOICES_TAB.Displayed);
            try
            {
                waitformee.Until(driver => _systemElements1.draft_TAB.Displayed);
                waitformee.Until(driver => _systemElements1.recurring_INVOICES_TAB.Displayed);
                waitformee.Until(driver => _systemElements1.archived_TAB.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Tab is not showing");
            }

            try
            {
                waitformee.Until(driver => _systemElements1.view_total.Displayed);
                waitformee.Until(driver => _systemElements1.sales_overdue.Displayed);
                waitformee.Until(driver => _systemElements1.view_unpaid.Displayed);
                waitformee.Until(driver => _systemElements1.view_paid.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: view links is nasdfsdfsot showing");
            }

            try
            {
                waitformee.Until(driver => _systemElements1.sales_add_new.Displayed);
                _systemElements1.sales_add_new.Click();
                waitformee.Until(driver => _systemElements1.sales_add_invoice.Displayed);
                waitformee.Until(driver => _systemElements1.sales_add_credit_note.Displayed);
                _systemElements1.sales_add_new.Click();

            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: view links is not showing");
            }
            try
            {
                waitformee.Until(driver => _systemElements1.salessearch_data_grid.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: search data  is not showing");
            }
            try
            {
                waitformee.Until(driver => _systemElements1.export.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: export link is not showing");
            }
            try
            {
                waitformee.Until(driver => _systemElements1.Filter.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: Filter link is not showing");
            }

            try
            {
                _systemElements1.financial_overivew_Fiscal_year.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
            }
            catch (Exception e) { Console.WriteLine("Faisdfl5"); }
            try
            {
                waitformee.Until(driver => _systemElements1.financial_overivew_six_months.Displayed);
            }
            catch (Exception e) { Console.WriteLine("Faisdfdsl5"); }

            try
            {
                waitformee.Until(driver => _systemElements1.financial_overivew_This_month.Displayed);
            }
            catch (Exception e) { Console.WriteLine("Faaswil5"); }

        }

        public void verify_sales_draft_page_display()
        {
            _systemElements1.draft_TAB.Click();
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            try
            {
                waitformee.Until(driver => _systemElements1.draft_title.Displayed);
            }
            catch (Exception e) { }

            bool display_page_size = _systemElements1.page_size_display();
            if (display_page_size == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();
            }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            waitformee.Until(driver => _systemElements1.draft_title.Displayed);
            string draft_counts = _systemElements1.draft_count.Text;
            int draft_count = Convert.ToInt32(draft_counts);
            if (draft_count != 0)
            {
                _systemElements1.no_of_col_and_rows(Constants.draft_col, Constants.draft_rows);
                int column_size = _systemElements1.global_col;
                row_size = _systemElements1.global_row;
                if (draft_count == row_size - 1)
                {
                    Console.WriteLine("Showing all records for draft:" + draft_count);
                }
                else
                {
                    Console.WriteLine("Fail active" + draft_count);
                }
            }
        }
        public void verify_sales_recurring_invoices_display()
        {
            _systemElements1.recurring_INVOICES_TAB.Click();
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            try
            {
                waitformee.Until(driver => _systemElements1.recurring_INVOICES_TAB.Displayed);
            }
            catch (Exception e) { }

            bool display_page_size = _systemElements1.page_size_display();
            if (display_page_size == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();
            }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            waitformee.Until(driver => _systemElements1.draft_title.Displayed);
            string recurring_counts = _systemElements1.recurring_invoice_count.Text;
            int reccurring_count = Convert.ToInt32(recurring_counts);
            if (reccurring_count != 0)
            {
                _systemElements1.no_of_col_and_rows(Constants.recurring_invoice_col, Constants.draft_rows);
                int column_size = _systemElements1.global_col;
                row_size = _systemElements1.global_row;
                if (reccurring_count == row_size - 1)
                {
                    Console.WriteLine("Showing all records for draft:" + reccurring_count);
                }
                else
                {
                    Assert.Fail("Fail active" + reccurring_count);
                }
            }
        }
        public void verify_sales_archived_display()
        {
            _systemElements1.archived_TAB.Click();
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            try
            {
                waitformee.Until(driver => _systemElements1.archived_TAB.Displayed);
            }
            catch (Exception e) { }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            bool display_page_size = _systemElements1.page_size_display();
            if (display_page_size == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();
            }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            waitformee.Until(driver => _systemElements1.draft_title.Displayed);
            string recurring_counts = _systemElements1.sales_archived_count.Text;
            int reccurring_count = Convert.ToInt32(recurring_counts);
            if (reccurring_count != 0)
            {
                _systemElements1.no_of_col_and_rows(Constants.sales_archived_col, Constants.draft_rows);
                int column_size = _systemElements1.global_col;
                row_size = _systemElements1.global_row;
                if (reccurring_count == row_size - 1)
                {
                    Console.WriteLine("Showing all records for draft:" + reccurring_count);
                }
                else
                {
                    Assert.Fail("Fail active" + reccurring_count);
                }
            }
        }


        public void verify_purchases_bills_page_display()
        {

            //bils
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitformee.Until(driver => _systemElements1.purchase_left_side.Displayed);
            if (_systemElements1.purchase_left_side.GetAttribute("aria-expanded") == "false")
            {
                _systemElements1.purchase_left_side.Click();
            }
            waitformee.Until(driver => _systemElements1.bills_left_side.Displayed);
            _systemElements1.bills_left_side.Click();
            waitformee.Until(driver => _systemElements1.ALL_bills_TAB.Displayed);
            try
            {
                waitformee.Until(driver => _systemElements1.bills_draft_TAB.Displayed);
                waitformee.Until(driver => _systemElements1.recurring_BILLS_TAB.Displayed);
                waitformee.Until(driver => _systemElements1.bills_archived_TAB.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Tab is not showing");
            }

            try
            {
                waitformee.Until(driver => _systemElements1.purchase_view_total.Displayed);
                waitformee.Until(driver => _systemElements1.purchase_overdue.Displayed);
                waitformee.Until(driver => _systemElements1.purchase_view_unpaid.Displayed);
                waitformee.Until(driver => _systemElements1.purchase_view_paid.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: view links is nasdfsdfsot showing");
            }

            try
            {
                waitformee.Until(driver => _systemElements1.sales_add_new.Displayed);
                _systemElements1.sales_add_new.Click();
                waitformee.Until(driver => _systemElements1.purchase_add_bill.Displayed);
                waitformee.Until(driver => _systemElements1.sales_add_credit_note.Displayed);
                _systemElements1.sales_add_new.Click();

            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: view links is not showing");
            }
            try
            {
                waitformee.Until(driver => _systemElements1.salessearch_data_grid.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: search data  is not showing");
            }
            try
            {
                waitformee.Until(driver => _systemElements1.export.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: export link is not showing");
            }
            try
            {
                waitformee.Until(driver => _systemElements1.Filter.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: Filter link is not showing");
            }

            try
            {
                _systemElements1.financial_overivew_Fiscal_year.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
            }
            catch (Exception e) { Console.WriteLine("Faisdfl5"); }
            try
            {
                waitformee.Until(driver => _systemElements1.financial_overivew_six_months.Displayed);
            }
            catch (Exception e) { Console.WriteLine("Faisdfdsl5"); }

            try
            {
                waitformee.Until(driver => _systemElements1.financial_overivew_This_month.Displayed);
            }
            catch (Exception e) { Console.WriteLine("Faaswil5"); }

        }

        public void verify_purchases_draft_page_display()
        {
            _systemElements1.bills_draft_TAB.Click();
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            try
            {
                waitformee.Until(driver => _systemElements1.draft_title.Displayed);
            }
            catch (Exception e) { }

            bool display_page_size = _systemElements1.page_size_display();
            if (display_page_size == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();
            }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            waitformee.Until(driver => _systemElements1.draft_title.Displayed);
            string draft_counts = _systemElements1.draft_count.Text;
            int draft_count = Convert.ToInt32(draft_counts);
            if (draft_count != 0)
            {
                _systemElements1.no_of_col_and_rows(Constants.sales_archived_col, Constants.draft_rows);
                int column_size = _systemElements1.global_col;
                row_size = _systemElements1.global_row;
                if (draft_count == row_size - 1)
                {
                    Console.WriteLine("Showing all records for draft:" + draft_count);
                }
                else
                {
                   // Assert.Fail("Fail active" + draft_count);
                }
            }
        }
        public void verify_purchases_recurring_bills_display()
        {
            _systemElements1.recurring_bills.Click();
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            try
            {
                waitformee.Until(driver => _systemElements1.recurring_BILLS_TAB.Displayed);
            }
            catch (Exception e) { }

            bool display_page_size = _systemElements1.page_size_display();
            if (display_page_size == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();
            }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            waitformee.Until(d => _systemElements1.draft_title.Displayed);
            string recurring_counts = _systemElements1.recurring_bill_count.Text;
            int reccurring_count = Convert.ToInt32(recurring_counts);
            if (reccurring_count != 0)
            {
                _systemElements1.no_of_col_and_rows(Constants.recurring_bills_col, Constants.draft_rows);
                int column_size = _systemElements1.global_col;
                row_size = _systemElements1.global_row;
                if (reccurring_count == row_size - 1)
                {
                    Console.WriteLine("Showing all records for draft:" + reccurring_count);
                }
                else
                {
                   // Assert.Fail("Fail active" + reccurring_count);
                }
            }
        }
        public void verify_purchases_archived_display()
        {
            _systemElements1.archived_TAB.Click();
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            try
            {
                waitformee.Until(driver => _systemElements1.bills_archived_TAB.Displayed);
            }
            catch (Exception e) { }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            bool display_page_size = _systemElements1.page_size_display();
            if (display_page_size == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();
            }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            waitformee.Until(driver => _systemElements1.draft_title.Displayed);
            string recurring_counts = _systemElements1.purchase_archived_count.Text;
            int reccurring_count = Convert.ToInt32(recurring_counts);
            if (reccurring_count != 0)
            {
                _systemElements1.no_of_col_and_rows(Constants.sales_archived_col, Constants.draft_rows);
                int column_size = _systemElements1.global_col;
                row_size = _systemElements1.global_row;
                if (reccurring_count == row_size - 1)
                {
                    Console.WriteLine("Showing all records for draft:" + reccurring_count);
                }
                else
                {
                    Assert.Fail("Fail active" + reccurring_count);
                }
            }
        }

        public void verify_staff_expenses_page_display()
        {

            //Expense
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(7));
            waitformee.Until(driver => _systemElements1.staff_expnses_left_menu.Displayed);
            _systemElements1.staff_expnses_left_menu.Click();
            waitformee.Until(driver => _systemElements1.all_expense_tab.Displayed);
            try
            {
                waitformee.Until(driver => _systemElements1.all_expense_tab.Displayed);
                waitformee.Until(driver => _systemElements1.awaiting_tab.Displayed);
                waitformee.Until(driver => _systemElements1.expense_tab_drafts.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Tab is not showing");
            }

            try
            {
                waitformee.Until(driver => _systemElements1.expense_view_unpaid.Displayed);
                waitformee.Until(driver => _systemElements1.expense_check_paid.Displayed);
                waitformee.Until(driver => _systemElements1.expense_view_total.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: view links is nasdfsdfsot showing");
            }

            try
            {
                waitformee.Until(driver => _systemElements1.add_new_expense.Displayed);
                waitformee.Until(driver => _systemElements1.add_new_mileage.Displayed);

            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: view links is not showing");
            }
            try
            {
                waitformee.Until(driver => _systemElements1.salessearch_data_grid.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: search data  is not showing");
            }
            try
            {
                waitformee.Until(driver => _systemElements1.export.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: export link is not showing");
            }
            try
            {
                waitformee.Until(driver => _systemElements1.Filter.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: Filter link is not showing");
            }

            try
            {
                _systemElements1.financial_overivew_Fiscal_year.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
            }
            catch (Exception e) { Console.WriteLine("Faisdfl5"); }
            try
            {
                waitformee.Until(driver => _systemElements1.financial_overivew_six_months.Displayed);
            }
            catch (Exception e) { Console.WriteLine("Faisdfdsl5"); }

            try
            {
                waitformee.Until(driver => _systemElements1.financial_overivew_This_month.Displayed);
            }
            catch (Exception e) { Console.WriteLine("Faaswil5"); }

        }


        public void verify_awaiting_payment_display()
        {

            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            try
            {
                waitformee.Until(driver => _systemElements1.awaiting_tab.Displayed);
                Thread.Sleep(TimeSpan.FromSeconds(2));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.awaiting_tab);
                waitformee.Until(driver => _systemElements1.draft_title.Displayed);
            }
            catch (Exception e) { }
            Thread.Sleep(TimeSpan.FromSeconds(2));
            bool display_page_size = _systemElements1.page_size_display();
            if (display_page_size == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();
            }
            Thread.Sleep(TimeSpan.FromSeconds(3));
             string no_of_pages = _systemElements1.number_of_pages.Text;
            //Console.WriteLine(no_of_pages);
            string items = no_of_pages.Substring(13, 3);
            Console.WriteLine("no of pages"+ items);

            waitformee.Until(d => _systemElements1.draft_title.Displayed);
            string recurring_counts = _systemElements1.awaiting_payment_count.Text;
            int reccurring_count = Convert.ToInt32(recurring_counts);
            if (reccurring_count != 0)
            {
                _systemElements1.no_of_col_and_rows(Constants.recurring_bills_col, Constants.draft_rows);
                int column_size = _systemElements1.global_col;
                row_size = _systemElements1.global_row;
                if (reccurring_count == row_size - 1)
                {
                    Console.WriteLine("Showing all records for draft:" + reccurring_count);
                }
                else
                {
                    Assert.Fail("Fail active" + reccurring_count);
                }
            }
        }

        public void verify_expnese_drafts_display()
        {

            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            try
            {
                waitformee.Until(driver => _systemElements1.expense_tab_drafts.Displayed);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.expense_tab_drafts);
                waitformee.Until(driver => _systemElements1.draft_title.Displayed);
            }
            catch (Exception e) { }

            bool display_page_size = _systemElements1.page_size_display();
            if (display_page_size == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();
            }
            Thread.Sleep(TimeSpan.FromSeconds(3));

            waitformee.Until(d => _systemElements1.draft_title.Displayed);
            string recurring_counts = _systemElements1.expense_drafts_count.Text;
            int reccurring_count = Convert.ToInt32(recurring_counts);
            if (reccurring_count != 0)
            {
                _systemElements1.no_of_col_and_rows(Constants.recurring_bills_col, Constants.draft_rows);
                int column_size = _systemElements1.global_col;
                row_size = _systemElements1.global_row;
                if (reccurring_count == row_size - 1)
                {
                    Console.WriteLine("Showing all records for draft:" + reccurring_count);
                }
                else
                {
                    Console.WriteLine("Fail active" + reccurring_count);
                }
            }
        }

        public void verify_chart_of_accounts_page_display()
        {

            //Chart of account
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitformee.Until(driver => _systemElements1.acccounting_left_menu.Displayed);
            if (_systemElements1.acccounting_left_menu.GetAttribute("aria-expanded") == "false")
            {
                _systemElements1.acccounting_left_menu.Click();
            }
            waitformee.Until(driver => _systemElements1.chart_of_accounts_left_side.Displayed);
            _systemElements1.chart_of_accounts_left_side.Click();
            waitformee.Until(driver => _systemElements1.All_accounts_tab.Displayed);
            try
            {
                waitformee.Until(driver => _systemElements1.Assets_tab.Displayed);
                waitformee.Until(driver => _systemElements1.Liabilities_tab.Displayed);
                waitformee.Until(driver => _systemElements1.Equity_tab.Displayed);
                waitformee.Until(driver => _systemElements1.Revenue_tab.Displayed);
                waitformee.Until(driver => _systemElements1.Expenses_tab.Displayed);
                waitformee.Until(driver => _systemElements1.archived_TAB.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Tab is not showing");
            }
            try
            {
                waitformee.Until(driver => _systemElements1.salessearch_data_grid.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: search data  is not showing");
            }
            try
            {
                waitformee.Until(driver => _systemElements1.export.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Test case fail: export link is not showing");
            }


        }
        public void verify_charts_of_account_count()
        {

            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            Thread.Sleep(TimeSpan.FromSeconds(3));
            bool display_page_size = _systemElements1.page_size_display();
            if (display_page_size == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();
            }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            string no_of_pages = _systemElements1.number_of_pages.Text;
            //Console.WriteLine(no_of_pages);
            string items = no_of_pages.Substring(13, 3);
            Console.WriteLine(items);
            int counts_items = Convert.ToInt32(items);
            if (counts_items > 90)
            {
                Console.WriteLine("showing records for all accounting");
            }
            else
            {
                Console.WriteLine("Less record or no record s223423howing");
            }
        }


        public void verify_assest_count()
        {
            //Assets
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.Assets_tab);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            bool display_page_size = _systemElements1.page_size_display();
            if (display_page_size == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();
            }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            try
            {
                string no_of_pages = _systemElements1.number_of_pages.Text;
                //Console.WriteLine(no_of_pages);
                string items = no_of_pages.Substring(13, 4);
                 Console.WriteLine(items);
                int counts_items = Convert.ToInt32(items);
                if (counts_items > 25)
                {
                    Console.WriteLine("showing records for all accounting");
                }
                else
                {
                    Console.WriteLine("Less record or no record1234324 showing");
                }
            }
            catch (Exception e)
            { }

            _systemElements1.no_of_col_and_rows(Constants.sales_archived_col, Constants.draft_rows);
            int column_size = _systemElements1.global_col;
            row_size = _systemElements1.global_row;
            Console.WriteLine("row"+ row_size);
            if (row_size >= 22)
            {
                Console.WriteLine("Showing all records for Asset:" + row_size);
            }
            else
            {
                Assert.Fail("Fail active" + row_size);
            }

        }


        public void verify_Liabilites_count()
        {
            //Assets
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.Liabilities_tab);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            bool display_page_size = _systemElements1.page_size_display();
            if (display_page_size == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();

            }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            try
            {
                string no_of_pages = _systemElements1.number_of_pages.Text;
                // Console.WriteLine(no_of_pages);
                string items = no_of_pages.Substring(13, 4);
                //  Console.WriteLine(items);
                int counts_items = Convert.ToInt32(items);
                if (counts_items > 15)
                {
                    Console.WriteLine("showing records for all accounting");
                }
                else
                {
                    Console.WriteLine("Less record or no rec3432421ord showing");
                }
            }
            catch (Exception e)
            { }

            _systemElements1.no_of_col_and_rows(Constants.sales_archived_col, Constants.draft_rows);
            int column_size = _systemElements1.global_col;
            row_size = _systemElements1.global_row;
            if (row_size >= 15)
            {
                Console.WriteLine("Showing all records for Asset:" + row_size);
            }
            else
            {
                Console.WriteLine("Fail active" + row_size);
            }
        }

        public void verify_equity_count()
        {
            //Assets
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.Equity_tab);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            bool display_page_size = _systemElements1.page_size_display();
            if (display_page_size == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();

            }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            try
            {
                string no_of_pages = _systemElements1.number_of_pages.Text;
                //Console.WriteLine(no_of_pages);
                string items = no_of_pages.Substring(13, 4);
                //Console.WriteLine(items);
                int counts_items = Convert.ToInt32(items);
                if (counts_items > 4)
                {
                    Console.WriteLine("showing records for all accounting");
                }
                else
                {
                    Console.WriteLine("Less record or no record shdasfsafsaowing");
                }
            }
            catch (Exception e)
            { }
            _systemElements1.no_of_col_and_rows(Constants.sales_archived_col, Constants.draft_rows);
            int column_size = _systemElements1.global_col;
            row_size = _systemElements1.global_row;
            if (row_size >= 4)
            {
                Console.WriteLine("Showing all records for Asset:" + row_size);
            }
            else
            {
                Assert.Fail("Fail active" + row_size);
            }

        }

        public void verify_revenue_count()
        {
            //Assets
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.Revenue_tab);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            bool display_page_size = _systemElements1.page_size_display();
            if (display_page_size == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();

            }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            try
            {
                string no_of_pages = _systemElements1.number_of_pages.Text;
                // Console.WriteLine(no_of_pages);
                string items = no_of_pages.Substring(13, 4);
                // Console.WriteLine(items);
                int counts_items = Convert.ToInt32(items);
                if (counts_items > 8)
                {
                    Console.WriteLine("showing records for all accounting");
                }
                else
                {
                    Console.WriteLine("Less record or no recor3242d showing");
                }
            }
            catch (Exception e)
            { }

            _systemElements1.no_of_col_and_rows(Constants.sales_archived_col, Constants.draft_rows);
            int column_size = _systemElements1.global_col;
            row_size = _systemElements1.global_row;
            if (row_size >= 8)
            {
                Console.WriteLine("Showing all records for Asset:" + row_size);
            }
            else
            {
                Console.WriteLine("Fail active" + row_size);
            }

        }

        public void verify_expenses_count()
        {
            //Assets
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.Expenses_tab);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            bool display_page_size = _systemElements1.page_size_display();
            if (display_page_size == true)
            {
                _systemElements1.itmes_50_display_on_page.Click();

            }
            Thread.Sleep(TimeSpan.FromSeconds(3));
            try
            {
                string no_of_pages = _systemElements1.number_of_pages.Text;
                // Console.WriteLine(no_of_pages);
                string items = no_of_pages.Substring(13, 4);
                //  Console.WriteLine(items);
                int counts_items = Convert.ToInt32(items);
                if (counts_items > 8)
                {
                    Console.WriteLine("showing records for all accounting");
                }
                else
                {
                    Console.WriteLine("Less record or no rec2111ord showing");
                }
            }
            catch (Exception e)
            { }

            _systemElements1.no_of_col_and_rows(Constants.sales_archived_col, Constants.draft_rows);
            int column_size = _systemElements1.global_col;
            int row_size = _systemElements1.global_row;
            if (row_size >= 8)
            {
                Console.WriteLine("Showing all records for Asset:" + row_size);
            }
            else
            {
                Assert.Fail("Fail active" + row_size);
            }
        }

        public void verify_dividends_display()
        {
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitformee.Until(driver => _systemElements1.acccounting_left_menu.Displayed);
            if (_systemElements1.acccounting_left_menu.GetAttribute("aria-expanded") == "false")
            {
                _systemElements1.acccounting_left_menu.Click();
            }
             ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.Dividends_left_side);
            waitformee.Until(driver => _systemElements1.Dividends_label.Displayed);

            try
            {
                waitformee.Until(driver => _systemElements1.all_Dividends_label.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("All Dividens labels not displaying");
            }
            try
            {
                string dividens_count = _systemElements1.all_Dividends_count.Text;
                bool no_record_showing = _systemElements1.no_dividend_showing();
                if (no_record_showing == true)
                {
                    Console.WriteLine("no record shosdfswing");
                }
                else
                {
                    Console.WriteLine("Need to add record");
                }
            }
            catch (Exception e) { }


            try
            {
                waitformee.Until(driver => _systemElements1.filter.Displayed);
                waitformee.Until(driver => _systemElements1.filter_icon.Displayed);
                waitformee.Until(driver => _systemElements1.add_Dividend_button.Displayed);
            }
            catch (Exception e)
            {
                Console.WriteLine("Filter/filter icon/ dividend button is not showing");
            }

            perform_showing_dividens_fields();



        }
        public void verify_fixed_assests_display()
        {
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitformee.Until(driver => _systemElements1.acccounting_left_menu.Displayed);
            if (_systemElements1.acccounting_left_menu.GetAttribute("aria-expanded") == "false")
            {
                //_systemElements1.acccounting_left_menu.Click();
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.acccounting_left_menu);
            }
             ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.fixed_assets_left_side);
            try
            {

                waitformee.Until(driver => _systemElements1.Acquired_assets_tab.Displayed);
                Thread.Sleep(TimeSpan.FromSeconds(3));
                string Acquired_assets_count_values = _systemElements1.Acquired_assets_count.Text;
                string Disposed_assets_count_values = _systemElements1.Disposed_assets_count.Text;

                int Acquired_assets_count_value = Convert.ToInt32(Acquired_assets_count_values);
                Disposed_assets_count_value = Convert.ToInt32(Disposed_assets_count_values);

                if (Acquired_assets_count_value >= 1)
                {
                    bool display_page_size = _systemElements1.page_size_display();
                    if (display_page_size == true)
                    {
                        _systemElements1.itmes_50_display_on_page.Click();
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(3));

                    try
                    {
                        _systemElements1.no_of_col_and_rows(Constants.sales_archived_col, Constants.aquired_assets_rows);
                        int column_size = _systemElements1.global_col;
                        row_size = _systemElements1.global_row;
                        if (row_size - 1 == Acquired_assets_count_value)
                        {
                            Console.WriteLine("record are showing correct");
                        }
                        else
                        {
                            Console.WriteLine("record are showing in-corsdfdsrect");
                        }

                    }
                    catch (Exception e) { }
                }
            }
            catch (Exception e) { }
        }

        public void verify_disposed_assests_display()
        {
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.Disposed_assets_tab);
            try
            {
                waitformee.Until(driver => _systemElements1.Disposed_assets_tab.Displayed);
                Thread.Sleep(TimeSpan.FromSeconds(5));

                if (Disposed_assets_count_value >= 1)
                {
                    bool display_page_size = _systemElements1.page_size_display();
                    if (display_page_size == true)
                    {
                        _systemElements1.itmes_50_display_on_page.Click();
                    }
                    Thread.Sleep(TimeSpan.FromSeconds(3));
                    try
                    {

                        _systemElements1.no_of_col_and_rows(Constants.sales_archived_col, Constants.disposed_rows);
                        int column_size = _systemElements1.global_col;
                        int row_size = _systemElements1.global_row;
                        if (row_size - 1 == Disposed_assets_count_value)
                        {
                            Console.WriteLine("record are showing correct for disposed");
                        }
                        else
                        {
                            Console.WriteLine("record are showing in-corwerwerrect");
                        }
                    }
                    catch (Exception e) { }
                }
            }
            catch (Exception e) { }
        }

        public void verify_journals_display()
        {
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitformee.Until(driver => _systemElements1.acccounting_left_menu.Displayed);
            if (_systemElements1.acccounting_left_menu.GetAttribute("aria-expanded") == "false")
            {
                _systemElements1.acccounting_left_menu.Click();
            }
             ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.journals_left_side);
            try
            {
                waitformee.Until(driver => _systemElements1.jounrals_label.Displayed);
                Thread.Sleep(TimeSpan.FromSeconds(2));
            }
            catch (Exception e) { }

            try
            {
                waitformee.Until(driver => _systemElements1.posted_tab.Displayed);
                waitformee.Until(driver => _systemElements1.drafts_tab_journals.Displayed);
                waitformee.Until(driver => _systemElements1.archived_tab_journals.Displayed);
            }
            catch (Exception e) { Console.WriteLine("Tabs in jounral are missing"); }

            try
            {
                waitformee.Until(driver => _systemElements1.Add_filters.Displayed);
                waitformee.Until(driver => _systemElements1.export_button.Displayed);
                waitformee.Until(driver => _systemElements1.upload_icon.Displayed);
                waitformee.Until(driver => _systemElements1.salessearch_data_grid.Displayed);
            }
            catch (Exception e) { Console.WriteLine("search/add filters/export button/ upload icon are missing"); }


            try
            {
                waitformee.Until(driver => _systemElements1.Add_journal_button.Displayed);
                waitformee.Until(driver => _systemElements1.Add_opening_balance_button.Displayed);
            }
            catch (Exception e) { Console.WriteLine("Add journal or add opening balance button are missing"); }

        }

        public void add_journal_display_fields()
        {
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.Add_journal_button);
            try
            {
                waitformee.Until(driver => _systemElements1.add_journal_label.Displayed);
                Thread.Sleep(TimeSpan.FromSeconds(2));
                string label = _systemElements1.add_journal_label.Text;
                if (label == "Add Journal")
                {
                    Console.WriteLine("Add journal label is showing");
                }
                else
                {
                    Console.WriteLine("Fail for label is not showing");
                }
            }
            catch (Exception e) { }

            try
            {
                waitformee.Until(driver => _systemElements1.issue_date_mileage.Displayed);
                waitformee.Until(driver => _systemElements1.document_number_journal.Displayed);
                waitformee.Until(driver => _systemElements1.document_number_journal.Displayed);
                waitformee.Until(driver => _systemElements1.reference_textarea.Displayed);
            }
            catch (Exception e) { }

            //select drop down options for Vat
            try
            {
                SelectElement oSelect = new SelectElement(_systemElements1.VATTaxSettingDropDown);
                IList<IWebElement> elementCount = oSelect.Options;
                int iListSize = elementCount.Count;
                String no_vat = oSelect.Options.ElementAt(0).GetAttribute("data-content");
                String vat_inclusive = oSelect.Options.ElementAt(1).GetAttribute("data-content");
                String vat_exclusive = oSelect.Options.ElementAt(2).GetAttribute("data-content");

                if (no_vat == Constants.no_vat)
                {
                    Console.WriteLine("pass: no vat drop down is showing");
                }
                if (vat_inclusive == Constants.vat_inclusive)
                {
                    Console.WriteLine("pass: vat inclusive drop down is showing");
                }
                if (vat_exclusive == Constants.vat_execlusive)
                {
                    Console.WriteLine("pass: vat execlusive drop down is showing");
                }
            }
            catch (Exception e) { }


            //reference text area and account type
            try
            {
                waitformee.Until(driver => _systemElements1.reference_textarea.Displayed);
                perform_no_of_drop_down(_systemElements1.account_type_journals);
                int list_of_items = no_of_items;
               
                if(list_of_items >= 95)
                {
                    Console.WriteLine("Pass: Account type list drop down is showing all items");
                }
                else
                {
                    Console.WriteLine("Fail: drop down list is not showing all account type");
                }


                perform_no_of_drop_down(_systemElements1.account_type_journals_1);
                int list_of_itemss = no_of_items;

                if (list_of_itemss >= 95)
                {
                    Console.WriteLine("Pass: Account type list drop down is showing all items");
                }
                else
                {
                    Console.WriteLine("Fail: drop down list is not showing all account type");
                }
            }
            catch (Exception e) { }


            try
            {
                waitformee.Until(driver => _systemElements1.item_description_journals.Displayed);
                waitformee.Until(driver => _systemElements1.debit_journals.Displayed);
                waitformee.Until(driver => _systemElements1.credit_journals.Displayed);
                waitformee.Until(driver => _systemElements1.item_description_journals_1.Displayed);
                waitformee.Until(driver => _systemElements1.debit_journals_1.Displayed);
                waitformee.Until(driver => _systemElements1.total.Displayed);
                waitformee.Until(driver => _systemElements1.debit_total_journals.Displayed);
                waitformee.Until(driver => _systemElements1.credit_total_journals.Displayed);
                waitformee.Until(driver => _systemElements1.difference.Displayed);
                waitformee.Until(driver => _systemElements1.items_difference_journals.Displayed);
                waitformee.Until(driver => _systemElements1.add_item.Displayed);

                Console.WriteLine("Pass: All list for account type is showing");
            }
            catch (Exception e) 
            {
                Console.WriteLine("Some elements are not showing : Item description/ debit journals/credit_journals/total/debit_total_journals/credit_total_journals/difference/items_difference_journals/add_item");            
            }

            _systemElements1.cancel_journals.Click();
        }

        public void add_opening_balance_display_field()
        {
            WebDriverWait waitformee = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", _systemElements1.Add_opening_balance_button);
            try
            {
                waitformee.Until(driver => _systemElements1.add_journal_label.Displayed);
                Thread.Sleep(TimeSpan.FromSeconds(2));
                string label = _systemElements1.add_journal_label.Text;
                if (label == "Add Opening Balance")
                {
                    Console.WriteLine("Pass: Add Opening Balance is showing");
                }
                else
                {
                    Console.WriteLine("Fail: Add Opening Balance is not showing");
                }
            }
            catch (Exception e) { }

            try
            {
                waitformee.Until(driver => _systemElements1.issue_date_mileage.Displayed);
                waitformee.Until(driver => _systemElements1.document_number_journal.Displayed);
                waitformee.Until(driver => _systemElements1.document_number_journal.Displayed);
                waitformee.Until(driver => _systemElements1.reference_textarea.Displayed);
            }
            catch (Exception e) { }

         
          


            //reference text area and account type
            try
            {
                waitformee.Until(driver => _systemElements1.reference_textarea.Displayed);
                string text_by_default_opening_balance = _systemElements1.reference_textarea.Text;
                if(text_by_default_opening_balance == "Opening Balance")
                {
                    Console.WriteLine("Pass: by default oepning balance value is showing");
                }
                else
                {
                    Console.WriteLine("fail: by default oepning balance value is not showing");
                }
                perform_no_of_drop_down(_systemElements1.account_type_journals);
                int list_of_items = no_of_items;

                if (list_of_items >= 95)
                {
                    Console.WriteLine("Pass: Account type list drop down is showing all items");
                }
                else
                {
                    Console.WriteLine("Fail: drop down list is not showing all account type");
                }


                perform_no_of_drop_down(_systemElements1.account_type_journals_1);
                int list_of_itemss = no_of_items;

                if (list_of_itemss >= 95)
                {
                    Console.WriteLine("Pass: Account type list drop down is showing all items");
                }
                else
                {
                    Console.WriteLine("Fail: drop down list is not showing all account type");
                }
            }
            catch (Exception e) { }


            try
            {
                waitformee.Until(driver => _systemElements1.item_description_journals.Displayed);
                waitformee.Until(driver => _systemElements1.debit_journals.Displayed);
                waitformee.Until(driver => _systemElements1.credit_journals.Displayed);
                waitformee.Until(driver => _systemElements1.item_description_journals_1.Displayed);
                waitformee.Until(driver => _systemElements1.debit_journals_1.Displayed);
                waitformee.Until(driver => _systemElements1.total.Displayed);
                waitformee.Until(driver => _systemElements1.debit_total_journals.Displayed);
                waitformee.Until(driver => _systemElements1.credit_total_journals.Displayed);
                waitformee.Until(driver => _systemElements1.difference.Displayed);
                waitformee.Until(driver => _systemElements1.items_difference_journals.Displayed);
                waitformee.Until(driver => _systemElements1.add_item.Displayed);

                Console.WriteLine("Pass: All list for account type is showing");
            }
            catch (Exception e)
            {
                Console.WriteLine("Some elements are not showing : Item description/ debit journals/credit_journals/total/debit_total_journals/credit_total_journals/difference/items_difference_journals/add_item");
            }

            _systemElements1.cancel_journals.Click();

        }




    }
}



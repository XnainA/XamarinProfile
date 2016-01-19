﻿using System;
using Colors = XamarinProfile.Helpers.Color;
using Xamarin.Forms;

namespace XamarinProfile
{
	public class UserRegistrationView : ContentPage
	{
		public StackLayout mainLayout,stack_TopView ,stack_MiddleView,stack_CoverPage,stack_FirstExpert,stack_SecondExpert;

		public ScrollView scroll_Main;
		public Picker picker_Country;
		public Image img_iOS,img_Android,img_Forms,img_Testcloud,img_Insights,img_Certified;
		public CircleImage img_User;
		public Label lbl_Expert;
		public ButtonTextAlignment btn_Submit;
		public Entry txt_Fname,txt_Lname;
		public int Width = App.ScreenWidth;
		public int Height = App.ScreenHeight;
		public int iClicks = 0;


		public UserRegistrationView ()
		{
			stack_CoverPage = new StackLayout
			{
				WidthRequest=Width,
				HeightRequest = Width/3,
				BackgroundColor=Colors.DarkGray.ToFormsColor(),
			
			};

			img_User = new CircleImage
			{
				HorizontalOptions = LayoutOptions.Center,
				HeightRequest = Width/4,
				WidthRequest = Width/4,
				Source="CircleImage.png",
				TranslationY=-((Width/4)/2+10)
			};

			var ProfilePictureGestureRecognizer = new  TapGestureRecognizer 
			{
				//ViewModel.SelectPictureCommand.Execute(null);
				Command = new Command (() => {
					var result = DisplayActionSheet ("Pick a picture from:", "Cancel", null, "Gallery", "Camera");
					//CREATE LOGIC
					if (result.Equals ("Gallery")) {img_User.SetBinding(TapGestureRecognizer.CommandProperty,"SelectPictureCommand");}
					else if(result.Equals ("Camera")){img_User.SetBinding(TapGestureRecognizer.CommandProperty,"TakePictureCommand");}
				}),
				NumberOfTapsRequired = 1
			};
			img_User.GestureRecognizers.Add(ProfilePictureGestureRecognizer);

			txt_Fname = new Entry
			{
				WidthRequest = Width,
				HorizontalOptions = LayoutOptions.Center,
				Placeholder="FirstName",
				TextColor=Color.Black,
				BackgroundColor=Colors.Blue.ToFormsColor(),
				HeightRequest=Width/10
			};
			txt_Lname = new Entry
			{
				WidthRequest = Width,
				HorizontalOptions = LayoutOptions.Center,
				Placeholder="LastName",
				TextColor=Color.Black,
				BackgroundColor=Colors.Blue.ToFormsColor(),
				HeightRequest=Width/10
					
			};

			picker_Country = new Picker
			{
				WidthRequest = Width,
				HorizontalOptions = LayoutOptions.Center,
				Title="Location",
				HeightRequest=Width/10,
				BackgroundColor=Colors.Blue.ToFormsColor()

			};
			picker_Country.Items.Add("Afghanistan");
			picker_Country.Items.Add("Albania");
			picker_Country.Items.Add("Algeria");
			picker_Country.Items.Add("Andorra");
			picker_Country.Items.Add("Angola");
			picker_Country.Items.Add("Antigua and Barbuda");
			picker_Country.Items.Add("Argentina");
			picker_Country.Items.Add("Armenia");
			picker_Country.Items.Add("Aruba");
			picker_Country.Items.Add("Australia");
			picker_Country.Items.Add("Austria");
			picker_Country.Items.Add("Azerbaijan");

			picker_Country.Items.Add("Bahamas, The");
			picker_Country.Items.Add("Bahrain");
			picker_Country.Items.Add("Bangladesh");
			picker_Country.Items.Add("Barbados");
			picker_Country.Items.Add("Belarus");
			picker_Country.Items.Add("Belgium");
			picker_Country.Items.Add("Belize");
			picker_Country.Items.Add("Benin");
			picker_Country.Items.Add("Bhutan");
			picker_Country.Items.Add("Bolivia");
			picker_Country.Items.Add("Bosnia and Herzegovina");
			picker_Country.Items.Add("Botswana");
			picker_Country.Items.Add("Brazil");
			picker_Country.Items.Add("Brunei ");
			picker_Country.Items.Add("Algeria");
			picker_Country.Items.Add("Bulgaria");
			picker_Country.Items.Add("Burkina Faso");
			picker_Country.Items.Add("Burma");
			picker_Country.Items.Add("Burundi");

			picker_Country.Items.Add("Denmark");
			picker_Country.Items.Add("Djibouti");
			picker_Country.Items.Add("Dominica");
			picker_Country.Items.Add("Dominican Republic");

			picker_Country.Items.Add("Fiji");
			picker_Country.Items.Add("Finland");
			picker_Country.Items.Add("France");



			picker_Country.SelectedIndex = 0;
		

			btn_Submit= new ButtonTextAlignment
			{
				WidthRequest = Width/2,
				HorizontalOptions = LayoutOptions.Center,
				HeightRequest=Width/10,			
				Text="Submit",	
				FontSize=17,
				TextColor=Color.Black,
				BackgroundColor=Colors.Blue.ToFormsColor()
			};
			stack_TopView = new StackLayout
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest=Height/4,
				Padding= new Thickness(0,0,0,Height/40),
				//BackgroundColor=Color.Blue,
				Children=
				{
					stack_CoverPage,img_User
				}
			};
			lbl_Expert = new Label
			{
				Text="Expert",
			};
			stack_MiddleView = new StackLayout
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions=LayoutOptions.StartAndExpand,
				Padding= new Thickness(Width/4,Height/40,Width/4,0),
				//BackgroundColor=Color.Aqua,
				Spacing=Height/40,
				Children=
				{
					txt_Fname,txt_Lname,picker_Country,lbl_Expert


				}
			};
			 img_iOS = new Image
			{
				WidthRequest=Width/7,
				HeightRequest=Width/7,
				HorizontalOptions=LayoutOptions.Start,
				Source="iOS.png",
				BackgroundColor=Colors.DarkGray.ToFormsColor(),
				IsEnabled=false
			};

			var iOStapGestureRecognizer = new TapGestureRecognizer();
			iOStapGestureRecognizer.Tapped += (s, e) =>
			{
				if(img_iOS.IsEnabled==false)
				{
					img_iOS.IsEnabled=true;
					img_iOS.BackgroundColor=Colors.Blue.ToFormsColor();
					//img_iOS.Source="Android.png";
				}
				else
				{
					img_iOS.IsEnabled=false;
					img_iOS.BackgroundColor=Colors.DarkGray.ToFormsColor();
					//img_iOS.Source="iOS.png";

				}
			};
			img_iOS.GestureRecognizers.Add(iOStapGestureRecognizer);

			img_Certified = new Image
			{
				WidthRequest=Width/7,
				HeightRequest=Width/7,
				HorizontalOptions=LayoutOptions.Center,
				Source="Certified.png",
				BackgroundColor=Colors.DarkGray.ToFormsColor(),
				IsEnabled=false
			};

			var CertifiedtapGestureRecognizer = new TapGestureRecognizer();
			CertifiedtapGestureRecognizer.Tapped += (s, e) =>
			{
				if(img_Certified.IsEnabled==false)
				{
					img_Certified.IsEnabled=true;
					img_Certified.BackgroundColor=Colors.Blue.ToFormsColor();

				}
				else
				{
					img_Certified.IsEnabled=false;
					img_Certified.BackgroundColor=Colors.DarkGray.ToFormsColor();

				}
			};
			img_Certified.GestureRecognizers.Add(CertifiedtapGestureRecognizer);

			img_Android = new Image
			{
				WidthRequest=Width/7,
				HeightRequest=Width/7,
				HorizontalOptions=LayoutOptions.End,
				Source="Android.png",
				BackgroundColor=Colors.DarkGray.ToFormsColor(),
				IsEnabled=false
			};
			var AndroidtapGestureRecognizer = new TapGestureRecognizer();
			AndroidtapGestureRecognizer.Tapped += (s, e) =>
			{
				if(img_Android.IsEnabled==false)
				{
					img_Android.IsEnabled=true;
					img_Android.BackgroundColor=Colors.Blue.ToFormsColor();

				}
				else
				{
					img_Android.IsEnabled=false;
					img_Android.BackgroundColor=Colors.DarkGray.ToFormsColor();

				}
			};
			img_Android.GestureRecognizers.Add(AndroidtapGestureRecognizer);
			img_Forms = new Image
			{
				WidthRequest=Width/7,
				HeightRequest=Width/7,
				HorizontalOptions=LayoutOptions.Start,
				Source="Forms.png",
				BackgroundColor=Colors.DarkGray.ToFormsColor(),
				IsEnabled=false
			};
			var FormstapGestureRecognizer = new TapGestureRecognizer();
			FormstapGestureRecognizer.Tapped += (s, e) =>
			{
				if(img_Forms.IsEnabled==false)
				{
					img_Forms.IsEnabled=true;
					img_Forms.BackgroundColor=Colors.Blue.ToFormsColor();

				}
				else
				{
					img_Forms.IsEnabled=false;
					img_Forms.BackgroundColor=Colors.DarkGray.ToFormsColor();

				}
			};
			img_Forms.GestureRecognizers.Add(FormstapGestureRecognizer);

			img_Insights = new Image
			{
				WidthRequest=Width/7,
				HeightRequest=Width/7,
				HorizontalOptions=LayoutOptions.Center,
				Source="Insight.png",
				BackgroundColor=Colors.DarkGray.ToFormsColor(),
				IsEnabled=false
			};
			var InsightstapGestureRecognizer = new TapGestureRecognizer();
			InsightstapGestureRecognizer.Tapped += (s, e) =>
			{
				if(img_Insights.IsEnabled==false)
				{
					img_Insights.IsEnabled=true;
					img_Insights.BackgroundColor=Colors.Blue.ToFormsColor();

				}
				else
				{
					img_Certified.IsEnabled=false;
					img_Certified.BackgroundColor=Colors.DarkGray.ToFormsColor();

				}
			};
			img_Insights.GestureRecognizers.Add(InsightstapGestureRecognizer);

			img_Testcloud = new Image
			{
				WidthRequest=Width/7,
				HeightRequest=Width/7,
				HorizontalOptions=LayoutOptions.End,
				Source="TestCloud.png",
				BackgroundColor=Colors.DarkGray.ToFormsColor(),
				IsEnabled=false
			};
			var TestcloudtapGestureRecognizer = new TapGestureRecognizer();
			TestcloudtapGestureRecognizer.Tapped += (s, e) =>
			{
				if(img_Testcloud.IsEnabled==false)
				{
					img_Testcloud.IsEnabled=true;
					img_Testcloud.BackgroundColor=Colors.Blue.ToFormsColor();

				}
				else
				{
					img_Testcloud.IsEnabled=false;
					img_Testcloud.BackgroundColor=Colors.DarkGray.ToFormsColor();

				}
			};
			img_Testcloud.GestureRecognizers.Add(TestcloudtapGestureRecognizer);

			stack_FirstExpert = new StackLayout
			{
				HorizontalOptions=LayoutOptions.Center,
				VerticalOptions=LayoutOptions.StartAndExpand,
				Orientation=StackOrientation.Horizontal,
				//BackgroundColor=Color.Red,
				Spacing=Height/40,
				Children=
				{
					img_iOS,img_Certified,img_Android
				}
			};
			stack_SecondExpert = new StackLayout
			{
				HorizontalOptions=LayoutOptions.Center,
				VerticalOptions=LayoutOptions.StartAndExpand,
				Orientation=StackOrientation.Horizontal,
				Spacing=Height/40,
				Children=
				{
					img_Forms,img_Insights,img_Testcloud
				}
			};
			StackLayout stack_MainLayout = new StackLayout
			{
				HorizontalOptions = LayoutOptions.StartAndExpand,
				VerticalOptions=LayoutOptions.Fill,
				Spacing=Width/20,
				Children=
				{
					stack_MiddleView,stack_FirstExpert,stack_SecondExpert,btn_Submit
				}
				};
			
			scroll_Main = new ScrollView 
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,	
				VerticalOptions=LayoutOptions.Start,
			};
			scroll_Main.Content=stack_MainLayout;

			 mainLayout = new StackLayout 
			{ 
				HorizontalOptions = LayoutOptions.Fill,
				VerticalOptions=LayoutOptions.End,
				BackgroundColor=Color.White,
				WidthRequest=Width,
				HeightRequest=Height,
				Children = 
				{
					stack_TopView,scroll_Main
				}
			};
			
		
			this.Content = mainLayout;
		}
	}
}



﻿using System;

namespace MarkdownEditorDemo.Services
{
   public class ViewOptionsService
   {
      private bool _navBarVisible = false;

      public Action OnChanged { get; set; }

      public bool IsNavigationVisible { get { return _navBarVisible; } }

      //Change state by click on the button
      public void Toggle()
      {
         _navBarVisible = !_navBarVisible;//Change
         OnChanged?.Invoke();//Callback for reload//Callback for reload
      }

      //get additional css class for nav bar div
      public string NavBarClass
      {
         get
         {
            if (_navBarVisible) return String.Empty;//No additional css class for show nav bar
            return "d-none";//d-none class will hide the div
         }
      }
   }
}

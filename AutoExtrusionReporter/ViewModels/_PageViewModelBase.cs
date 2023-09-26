﻿/// <summary>
/// An abstract class for enabling page navigation.
/// </summary>
namespace AutoExtrusionReporter.ViewModels
{
    public abstract class PageViewModelBase : ViewModelBase
    {
        /// <summary>
        /// Gets if the user can navigate to the next page
        /// </summary>
        public abstract bool CanNavigateNext { get; protected set; }

        /// <summary>
        /// Gets if the user can navigate to the previous page
        /// </summary>
        public abstract bool CanNavigatePrevious { get; protected set; }
    }
}

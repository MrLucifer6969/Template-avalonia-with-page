using ReactiveUI;
using System.ComponentModel.DataAnnotations;
using System;
/// <summary>
///  This is our ViewModel for the second page
/// </summary>
namespace AutoExtrusionReporter.ViewModels;
/// 
public class PageThreeViewModel : PageViewModelBase
{
    public PageThreeViewModel()
    {
    }

    private bool _CanNavigateNext = false;

    // For this page the user can only go to the next page if all fields are valid. So we need a private setter.
    public override bool CanNavigateNext
    {
        get { return _CanNavigateNext; }
        protected set { this.RaiseAndSetIfChanged(ref _CanNavigateNext, value); }
    }

    // We allow navigate back in any case
    public override bool CanNavigatePrevious
    {
        get => true;
        protected set => throw new NotSupportedException();
    }
}
using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;

namespace WPFDemo;

public class DemoViewModel : ViewModel
{
    private Score data;
    public Score Data
    {
        get { return data; }
        set
        {
            data = value;
            OnPropertyChanged(() => Data);
        }
    }

    public void LoadData()
    {
        var score = Score.CreateOneStaffScore(Clef.Treble, new MajorScale(Step.C, false));
        Data = score;
    }
}
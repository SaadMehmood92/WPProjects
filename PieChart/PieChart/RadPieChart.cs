using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Telerik.Charting;

namespace PieChart
{
  /// <summary>
  /// Represents a special chart that visualizes its data points using arc segments.
  /// 
  /// </summary>
  public class RadPieChart : RadChartBase
  {
    private ChartAreaModel pieArea;
    private PresenterCollection<PieSeries> series;

    /// <summary>
    /// Gets all the data points plotted by this chart.
    /// 
    /// </summary>
    public PresenterCollection<PieSeries> Series
    {
      get
      {
        return this.series;
      }
    }

    internal override IEnumerable<ChartSeries> SeriesInternal
    {
      get
      {
        RadPieChart.\u003Cget_SeriesInternal\u003Ed__0 seriesInternalD0 = new RadPieChart.\u003Cget_SeriesInternal\u003Ed__0(-2);
        seriesInternalD0.\u003C\u003E4__this = this;
        return (IEnumerable<ChartSeries>) seriesInternalD0;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Telerik.Windows.Controls.RadPieChart"/> class.
    /// 
    /// </summary>
    public RadPieChart()
    {
      base.\u002Ector();
      this.series = new PresenterCollection<PieSeries>((RadChartBase) this);
    }

    /// <summary>
    /// Creates the model of the plot area.
    /// 
    /// </summary>
    /// 
    /// <returns/>
    internal override ChartAreaModel CreateChartAreaModel()
    {
      this.pieArea = new ChartAreaModel();
      return this.pieArea;
    }

    [CompilerGenerated]
    private sealed class \u003Cget_SeriesInternal\u003Ed__0 : IEnumerable<ChartSeries>, IEnumerable, IEnumerator<ChartSeries>, IEnumerator, IDisposable
    {
      private ChartSeries \u003C\u003E2__current;
      private int \u003C\u003E1__state;
      private int \u003C\u003El__initialThreadId;
      public RadPieChart \u003C\u003E4__this;
      public ChartSeries \u003Cseries\u003E5__1;
      public IEnumerator<PieSeries> \u003C\u003E7__wrap2;

      ChartSeries IEnumerator<ChartSeries>.Current
      {
        [DebuggerHidden] get
        {
          return this.\u003C\u003E2__current;
        }
      }

      object IEnumerator.Current
      {
        [DebuggerHidden] get
        {
          return (object) this.\u003C\u003E2__current;
        }
      }

      [DebuggerHidden]
      public \u003Cget_SeriesInternal\u003Ed__0(int \u003C\u003E1__state)
      {
        base.\u002Ector();
        this.\u003C\u003E1__state = param0;
        this.\u003C\u003El__initialThreadId = Thread.CurrentThread.ManagedThreadId;
      }

      [DebuggerHidden]
      IEnumerator<ChartSeries> IEnumerable<ChartSeries>.GetEnumerator()
      {
        RadPieChart.\u003Cget_SeriesInternal\u003Ed__0 seriesInternalD0;
        if (Thread.CurrentThread.ManagedThreadId == this.\u003C\u003El__initialThreadId && this.\u003C\u003E1__state == -2)
        {
          this.\u003C\u003E1__state = 0;
          seriesInternalD0 = this;
        }
        else
        {
          seriesInternalD0 = new RadPieChart.\u003Cget_SeriesInternal\u003Ed__0(0);
          seriesInternalD0.\u003C\u003E4__this = this.\u003C\u003E4__this;
        }
        return (IEnumerator<ChartSeries>) seriesInternalD0;
      }

      [DebuggerHidden]
      IEnumerator IEnumerable.GetEnumerator()
      {
        return (IEnumerator) this.System\u002ECollections\u002EGeneric\u002EIEnumerable\u003CTelerik\u002EWindows\u002EControls\u002EChartSeries\u003E\u002EGetEnumerator();
      }

      bool IEnumerator.MoveNext()
      {
        // ISSUE: fault handler
        try
        {
          switch (this.\u003C\u003E1__state)
          {
            case 0:
              this.\u003C\u003E1__state = -1;
              this.\u003C\u003E7__wrap2 = this.\u003C\u003E4__this.series.GetEnumerator();
              this.\u003C\u003E1__state = 1;
              break;
            case 2:
              this.\u003C\u003E1__state = 1;
              break;
            default:
              return false;
          }
          if (this.\u003C\u003E7__wrap2.MoveNext())
          {
            this.\u003Cseries\u003E5__1 = (ChartSeries) this.\u003C\u003E7__wrap2.Current;
            this.\u003C\u003E2__current = this.\u003Cseries\u003E5__1;
            this.\u003C\u003E1__state = 2;
            return true;
          }
          else
          {
            this.\u003C\u003Em__Finally3();
            goto default;
          }
        }
        __fault
        {
          this.System\u002EIDisposable\u002EDispose();
        }
      }

      [DebuggerHidden]
      void IEnumerator.Reset()
      {
        throw new NotSupportedException();
      }

      void IDisposable.Dispose()
      {
        switch (this.\u003C\u003E1__state)
        {
          case 1:
          case 2:
            try
            {
            }
            finally
            {
              this.\u003C\u003Em__Finally3();
            }
            break;
        }
      }

      private void \u003C\u003Em__Finally3()
      {
        this.\u003C\u003E1__state = -1;
        if (this.\u003C\u003E7__wrap2 == null)
          return;
        this.\u003C\u003E7__wrap2.Dispose();
      }
    }
  }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ScatterSeries.cs" company="OxyPlot">
//   http://oxyplot.codeplex.com, license: Ms-PL
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OxyPlot.Wpf
{
    using System;
    using System.Windows;
    using System.Windows.Media;

    /// <summary>
    /// This is a WPF wrapper of OxyPlot.ScatterSeries
    /// </summary>
    public class ScatterSeries : XYAxisSeries
    {
        #region Constants and Fields

        /// <summary>
        ///   The bin size property.
        /// </summary>
        public static readonly DependencyProperty BinSizeProperty = DependencyProperty.Register(
            "BinSize", typeof(int), typeof(ScatterSeries), new PropertyMetadata(0, AppearanceChanged));

        /// <summary>
        ///   The data field size property.
        /// </summary>
        public static readonly DependencyProperty DataFieldSizeProperty = DependencyProperty.Register(
            "DataFieldSize", typeof(string), typeof(ScatterSeries), new PropertyMetadata(null, DataChanged));

        /// <summary>
        ///   The data field tag property.
        /// </summary>
        public static readonly DependencyProperty DataFieldTagProperty = DependencyProperty.Register(
            "DataFieldTag", typeof(string), typeof(ScatterSeries), new PropertyMetadata(null, DataChanged));

        /// <summary>
        ///   The data field value property.
        /// </summary>
        public static readonly DependencyProperty DataFieldValueProperty = DependencyProperty.Register(
            "DataFieldValue", typeof(string), typeof(ScatterSeries), new PropertyMetadata(null, DataChanged));

        /// <summary>
        ///   The data field x property.
        /// </summary>
        public static readonly DependencyProperty DataFieldXProperty = DependencyProperty.Register(
            "DataFieldX", typeof(string), typeof(ScatterSeries), new PropertyMetadata("X", DataChanged));

        /// <summary>
        ///   The data field y property.
        /// </summary>
        public static readonly DependencyProperty DataFieldYProperty = DependencyProperty.Register(
            "DataFieldY", typeof(string), typeof(ScatterSeries), new PropertyMetadata("Y", DataChanged));

        /// <summary>
        ///   The mapping property.
        /// </summary>
        public static readonly DependencyProperty MappingProperty = DependencyProperty.Register(
            "Mapping", typeof(Func<object, IDataPoint>), typeof(ScatterSeries), new PropertyMetadata(null, DataChanged));

        /// <summary>
        ///   The marker fill property.
        /// </summary>
        public static readonly DependencyProperty MarkerFillProperty = DependencyProperty.Register(
            "MarkerFill", typeof(Color?), typeof(ScatterSeries), new PropertyMetadata(null, AppearanceChanged));

        /// <summary>
        ///   The marker outline property.
        /// </summary>
        public static readonly DependencyProperty MarkerOutlineProperty = DependencyProperty.Register(
            "MarkerOutline", typeof(ScreenPoint[]), typeof(ScatterSeries), new PropertyMetadata(null, AppearanceChanged));

        /// <summary>
        ///   The marker size property.
        /// </summary>
        public static readonly DependencyProperty MarkerSizeProperty = DependencyProperty.Register(
            "MarkerSize", typeof(double), typeof(ScatterSeries), new PropertyMetadata(5.0, AppearanceChanged));

        /// <summary>
        ///   The marker stroke property.
        /// </summary>
        public static readonly DependencyProperty MarkerStrokeProperty = DependencyProperty.Register(
            "MarkerStroke", typeof(Color?), typeof(ScatterSeries), new PropertyMetadata(null, AppearanceChanged));

        /// <summary>
        ///   The marker stroke thickness property.
        /// </summary>
        public static readonly DependencyProperty MarkerStrokeThicknessProperty =
            DependencyProperty.Register(
                "MarkerStrokeThickness", 
                typeof(double), 
                typeof(ScatterSeries), 
                new PropertyMetadata(1.0, AppearanceChanged));

        /// <summary>
        ///   The marker type property.
        /// </summary>
        public static readonly DependencyProperty MarkerTypeProperty = DependencyProperty.Register(
            "MarkerType", 
            typeof(MarkerType), 
            typeof(ScatterSeries), 
            new PropertyMetadata(MarkerType.Square, AppearanceChanged));

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///   Initializes a new instance of the <see cref = "ScatterSeries" /> class.
        /// </summary>
        public ScatterSeries()
        {
            this.internalSeries = new OxyPlot.ScatterSeries();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///   Gets or sets BinSize.
        /// </summary>
        public int BinSize
        {
            get
            {
                return (int)this.GetValue(BinSizeProperty);
            }

            set
            {
                this.SetValue(BinSizeProperty, value);
            }
        }

        /// <summary>
        ///   Gets or sets DataFieldSize.
        /// </summary>
        public string DataFieldSize
        {
            get
            {
                return (string)this.GetValue(DataFieldSizeProperty);
            }

            set
            {
                this.SetValue(DataFieldSizeProperty, value);
            }
        }

        /// <summary>
        ///   Gets or sets DataFieldTag.
        /// </summary>
        public string DataFieldTag
        {
            get
            {
                return (string)this.GetValue(DataFieldTagProperty);
            }

            set
            {
                this.SetValue(DataFieldTagProperty, value);
            }
        }

        /// <summary>
        ///   Gets or sets DataFieldValue.
        /// </summary>
        public string DataFieldValue
        {
            get
            {
                return (string)this.GetValue(DataFieldValueProperty);
            }

            set
            {
                this.SetValue(DataFieldValueProperty, value);
            }
        }

        /// <summary>
        ///   Gets or sets DataFieldX.
        /// </summary>
        public string DataFieldX
        {
            get
            {
                return (string)this.GetValue(DataFieldXProperty);
            }

            set
            {
                this.SetValue(DataFieldXProperty, value);
            }
        }

        /// <summary>
        ///   Gets or sets DataFieldY.
        /// </summary>
        public string DataFieldY
        {
            get
            {
                return (string)this.GetValue(DataFieldYProperty);
            }

            set
            {
                this.SetValue(DataFieldYProperty, value);
            }
        }

        /// <summary>
        ///   Gets or sets Mapping.
        /// </summary>
        public Func<object, IDataPoint> Mapping
        {
            get
            {
                return (Func<object, IDataPoint>)this.GetValue(MappingProperty);
            }

            set
            {
                this.SetValue(MappingProperty, value);
            }
        }

        /// <summary>
        ///   Gets or sets MarkerFill.
        /// </summary>
        public Color? MarkerFill
        {
            get
            {
                return (Color?)this.GetValue(MarkerFillProperty);
            }

            set
            {
                this.SetValue(MarkerFillProperty, value);
            }
        }

        /// <summary>
        ///   Gets or sets MarkerOutline.
        /// </summary>
        public ScreenPoint[] MarkerOutline
        {
            get
            {
                return (ScreenPoint[])this.GetValue(MarkerOutlineProperty);
            }

            set
            {
                this.SetValue(MarkerOutlineProperty, value);
            }
        }

        /// <summary>
        ///   Gets or sets MarkerSize.
        /// </summary>
        public double MarkerSize
        {
            get
            {
                return (double)this.GetValue(MarkerSizeProperty);
            }

            set
            {
                this.SetValue(MarkerSizeProperty, value);
            }
        }

        /// <summary>
        ///   Gets or sets MarkerStroke.
        /// </summary>
        public Color? MarkerStroke
        {
            get
            {
                return (Color?)this.GetValue(MarkerStrokeProperty);
            }

            set
            {
                this.SetValue(MarkerStrokeProperty, value);
            }
        }

        /// <summary>
        ///   Gets or sets MarkerStrokeThickness.
        /// </summary>
        public double MarkerStrokeThickness
        {
            get
            {
                return (double)this.GetValue(MarkerStrokeThicknessProperty);
            }

            set
            {
                this.SetValue(MarkerStrokeThicknessProperty, value);
            }
        }

        /// <summary>
        ///   Gets or sets MarkerType.
        /// </summary>
        public MarkerType MarkerType
        {
            get
            {
                return (MarkerType)this.GetValue(MarkerTypeProperty);
            }

            set
            {
                this.SetValue(MarkerTypeProperty, value);
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// The create model.
        /// </summary>
        /// <returns>
        /// </returns>
        public override OxyPlot.Series CreateModel()
        {
            this.SynchronizeProperties(this.internalSeries);
            return this.internalSeries;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The synchronize properties.
        /// </summary>
        /// <param name="series">
        /// The series.
        /// </param>
        protected override void SynchronizeProperties(OxyPlot.ISeries series)
        {
            base.SynchronizeProperties(series);
            var s = series as OxyPlot.ScatterSeries;
            if (s != null)
            {
                s.MarkerFill = this.MarkerFill.ToOxyColor();
                s.MarkerStroke = this.MarkerStroke.ToOxyColor();
                s.MarkerStrokeThickness = this.MarkerStrokeThickness;
                s.MarkerType = this.MarkerType;
                s.MarkerSize = this.MarkerSize;
                s.DataFieldX = this.DataFieldX;
                s.DataFieldY = this.DataFieldY;
                s.DataFieldSize = this.DataFieldSize;
                s.DataFieldValue = this.DataFieldValue;
                s.DataFieldTag = this.DataFieldTag;
                s.ItemsSource = this.ItemsSource;
                s.BinSize = this.BinSize;
                s.Mapping = this.Mapping;
                s.MarkerOutline = this.MarkerOutline;
            }
        }

        #endregion
    }
}
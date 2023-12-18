using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    public class FurnitureItem
    {
        public string Name;
        public double Price;
        public double Height;
        public double Width;
        public double Weight;

        public FurnitureItem(string productName, double price, double height, double width, double weight)
        {
            this.Name = productName;
            this.Price = price;
            this.Height = height;
            this.Width = width;
            this.Weight = weight;
        }
    }

    public class InventoryReport
    {
        public string TitleSection;
        public string DimensionsSection;
        public string LogisticsSection;

        public string Debug()
        {
            return new StringBuilder()
                .AppendLine(TitleSection)
                .AppendLine(DimensionsSection)
                .AppendLine(LogisticsSection)
                .ToString();
        }
    }

    public interface IFurnitureInventoryBuilder
    {
        void AddTitle();
        void AddDimensions();
        void AddLogistics(DateTime dateTime);
        InventoryReport GetDailyReport();
    }

    public class DailyReportBuilder : IFurnitureInventoryBuilder
    {
        private InventoryReport _report;
        private IEnumerable<FurnitureItem> _items;
        public DailyReportBuilder(IEnumerable<FurnitureItem> items)
        {
            this.Reset();
            _items = items;
        }
        public void Reset()
        {
            _report = new InventoryReport();
        }

        public void AddTitle()
        {
            _report.TitleSection = "------ Daily report ---------- \n\n";
        }

        public void AddDimensions()
        {
            _report.DimensionsSection = string.Join(Environment.NewLine, _items.Select(i =>
            $"Product: {i.Name} \n  Price: {i.Price} \n" +
            $"Height: {i.Height} x Width: {i.Width} -> Weight: {i.Weight}"));
        }

        public void AddLogistics(DateTime dateTime)
        {
            _report.LogisticsSection = $"Report generated on {dateTime}";
        }


        public InventoryReport GetDailyReport()
        {
            var finishedReport = _report;
            this.Reset();

            return finishedReport;
        }
    }

    public class InventoryBuildDirector
    {
        private readonly IFurnitureInventoryBuilder _builder;

        public InventoryBuildDirector(IFurnitureInventoryBuilder concreteBuilder)
        {
            _builder = concreteBuilder;
        }

        public void BuildCompleteReport()
        {
            _builder.AddTitle();
            _builder.AddDimensions();
            _builder.AddLogistics(DateTime.Now);

        }
    }
}

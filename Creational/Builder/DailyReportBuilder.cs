using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder_Pattern
{
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

        public IFurnitureInventoryBuilder AddTitle()
        {
            _report.TitleSection = "------ Daily report ---------- \n\n";
            return this;
        }

        public IFurnitureInventoryBuilder AddDimensions()
        {
            _report.DimensionsSection = string.Join(Environment.NewLine, _items.Select(i =>
            $"Product: {i.Name} \n  Price: {i.Price} \n" +
            $"Height: {i.Height} x Width: {i.Width} -> Weight: {i.Weight}"));

            return this;
        }

        public IFurnitureInventoryBuilder AddLogistics(DateTime dateTime)
        {
            _report.LogisticsSection = $"Report generated on {dateTime}";
            return this;
        }


        public InventoryReport GetDailyReport()
        {
            var finishedReport = _report;
            this.Reset();

            return finishedReport;
        }
    }
}

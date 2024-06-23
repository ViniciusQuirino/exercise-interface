using System.Globalization;

namespace Entities
{
    class Installment
    {

        public DateTime dueDate { get; set; }
        public double value { get; set; }

        public Installment(DateTime dueDate, double value)
        {
            this.dueDate = dueDate;
            this.value = value;
        }

        public override string ToString()
        {
            return $"{dueDate.ToString("dd/MM/yyyy")} - {value.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
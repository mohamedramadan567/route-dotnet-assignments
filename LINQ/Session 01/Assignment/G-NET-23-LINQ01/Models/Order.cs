namespace G_NET_23_LINQ01.Models
{
	public class Order
	{
		public int OrderID { get; set; }
		public DateTime OrderDate { get; set; }
		public decimal Total { get; set; }
		public override string ToString() => $"{OrderID}: {OrderDate:d} for {Total:C2}";
	}
}
public interface IRoad
{

  public int RowCount { get; }
  public int ColCount { get; }

  void SetVehicle(int row, int column, IVehicle vehicle);
  IVehicle? GetVehicle(int row, int column);
}

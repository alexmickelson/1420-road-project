using System.ComponentModel;

public class Road
{

  public IVehicle[][] Vehicles { get; private set; }

  public Road(int rowCount, int colCount)
  {
    Vehicles = new IVehicle[rowCount][];
    for (int i = 0; i < rowCount; i++)
    {
      Vehicles[i] = new IVehicle[colCount];
    }
  }

  public void SetVehicle(int row, int column, IVehicle vehicle)
  {
    Vehicles[row][column] = vehicle;
  }

  public IVehicle GetVehicle(int row, int column)
  {
    return Vehicles[row][column];
  }
}
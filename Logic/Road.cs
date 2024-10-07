using System.ComponentModel;

public class Road
{

  public IVehicle?[][] Vehicles { get; private set; }

  public Road(int rowCount, int colCount)
  {
    // initialize the first array to represent each row
    // iterate through the first array with a for loop, initialize each position in the first array to be an array of IVehicles
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

  public IVehicle? GetVehicle(int row, int column)
  {
    return Vehicles[row][column];
  }
}
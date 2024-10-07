using System.ComponentModel;

public class Road : IRoad
{

  public IVehicle?[][] Vehicles { get; private set; }

  public int RowCount { get; }
  public int ColCount { get; }

  public Road(int rowCount, int colCount)
  {
    // initialize the first array to represent each row
    // the second dimension of the array represents the columns
    // iterate through the first array with a loop, in each 'row' initialize an IVehicle[] large enough to store each 'column'
    Vehicles = new IVehicle[rowCount][];
    for (int i = 0; i < rowCount; i++)
    {
      Vehicles[i] = new IVehicle[colCount];
    }

    RowCount = rowCount;
    ColCount = colCount;
  }

  public void SetVehicle(int row, int column, IVehicle vehicle)
  {
    // implement
    Vehicles[row][column] = vehicle;
  }

  public IVehicle? GetVehicle(int row, int column)
  {
    // implement
    return Vehicles[row][column];
  }
}
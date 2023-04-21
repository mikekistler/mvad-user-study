/*
 * See the README.md for a brief introduction to the Anomaly Detector service.
 */

using Azure;
using Azure.AI.AnomalyDetector;

string _apiKey = Environment.GetEnvironmentVariable("ANOMALY_DETECTOR_APIKEY");
string _endpoint = Environment.GetEnvironmentVariable("ANOMALY_DETECTOR_ENDPOINT");

#region TASK 1
/*
 * Create an Anomaly Detector client object that authenticates with an API key.
 * The endpoint and API key to use are stored in the _apiKey and _endpoint variables.
 */
// CODE FOR TASK 1 GOES HERE
#endregion

//Task2();
//var model = Task3();
//var modelId = Task4();
// int? numAnomalies = Task5(modelId);
// Console.WriteLine($"Number of anomalies detected: {numAnomalies}");
//Task6(modelId);

#region TASK 2
/*
 * Print the number of multivariate models in the service.
 */
void Task2()
{
    // CODE FOR TASK 2 GOES HERE
}
#endregion

#region TASK 3
/*
 * Create and train a multivariate anomaly detector model.
 * The training data is located at https://multivariateuserstudy.blob.core.windows.net/anomalydetectordata/training_data.csv
 * The training data is a sequence of timestamped sensor readings from 5 sensors
 * stored as comma-separated values in a single table, where each line
 * contains a timestamp and the values of the 5 sensor readings.
 * The data contains data points for the period 2021-01-01T00:00:00Z to 2021-01-02T09:19:00Z.
 * Return the model object when it's ready for use.
 * If the training failed, return null.
 */
AnomalyDetectionModel Task3()
{
    // CODE FOR TASK 3 GOES HERE
    return null!;
}
#endregion

#region TASK 4
/*
 * Print the number of multivariate models in the service that are ready to use.
 * Return the model ID of the model that you created in Task 3.
 */
string Task4()
{
    // CODE FOR TASK 4 GOES HERE
    return null!;
}
#endregion

#region TASK 5
/*
 * Perform a bulk analysis of multivariate sensor data using the model you created in Task 3.
 * The data is located at https://multivariateuserstudy.blob.core.windows.net/anomalydetectordata/sensors.csv
 * The data is stored as comma-separated values in a single table, where each line
 * contains a timestamp and the values of the 5 sensor readings.
 * The data contains data points for the period 2021-01-02T14:20:00Z to 2021-01-03T01:59:00Z.
 * Return the number of anomalies detected.
 */
int? Task5(string modelId)
{
    // CODE FOR TASK 5 GOES HERE
    return null;
}
#endregion

#region TASK 6
/*
 * Perform a bulk analysis of multivariate sensor data using the model you created in Task 3.
 * The data is located at https://multivariateuserstudy.blob.core.windows.net/anomalydetectordata/sensors2.csv
 * The data is stored as comma-separated values in a single table, where each line
 * contains a timestamp and the values of the 5 sensor readings.
 * The data contains data points for the period 2021-01-02T09:20:00Z to 2021-01-02T12:38:00Z.
 * There's a problem with the data that will cause the analysis to fail. You should add error handling
 * logic to your function to catch the error and return an English description of the error.
 */
void Task6(string modelId)
{
    // CODE FOR TASK 6 GOES HERE
}
#endregion

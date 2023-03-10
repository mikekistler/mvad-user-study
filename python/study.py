#!/usr/bin/env python

import dateparser
import os
import time

from azure.ai.anomalydetector import *
from azure.ai.anomalydetector.models import *
from azure.core.credentials import *

# An instance of the Anomaly Detector service has already been provisioned for you.
endpoint = os.environ["ANOMALY_DETECTOR_ENDPOINT"]
key = os.environ["ANOMALY_DETECTOR_APIKEY"]

# Task 1:
# Write a function to print the number of multivariate models in the service.

def task1():
    # Code goes here
    return None

task1()

# Task 2:
# Write a function to create and train a multivariate anomaly detector model.
# The training data is a sequence of time-stamped sensor readings from five sensors.
# The data is stored as a comma-separated values in a single table, where each line
# contains a time-stamp and then the values of the five sensor readings.
# The data contains data points for the period 2021-01-01T00:00:00Z to 2021-01-01T08:19:00Z.
# The data is located at https://userstudystorageaccount.blob.core.windows.net/mvad-user-study/training_data.csv
# Return the model object when it is ready for use.
# If the training failed return None

def task2() -> AnomalyDetectionModel:
    # Code goes here
    return None

#task2()

# Task 3:
# Write a function to print the number of multivariate models in the service that are ready to use
# and return the modelId of the model that you created in task2.
def task3() -> str:
    # Code goes here
    return None

# model_id = task3()
# print(f'model_id is {model_id}')

# Task 4:
# Write a function to perform a bulk analysis of multivariate sensor data and return
# a count of the number of anomalies detected.
# The data is stored as a comma-separated values in a single table, where each line
# contains a time-stamp and then the values of the five sensor readings.
# The data contains data points for the period 2021-01-02T09:20:00Z to 2021-01-03T01:59:00Z.
# The data is located at https://userstudystorageaccount.blob.core.windows.net/mvad-user-study/sensors.csv

def task4(model_id: str) -> int:
    # Code goes here
    return None

# count = task4(model_id)
# print(f'Number of anomalies detected is {count}')

# Task 5:
# Write a function to perform a bulk analysis of multivariate sensor data for a data set we provide.
# There is a problem with the data that will cause the analysis to fail. You should add error handling
# logic to your function to catch the error and return an English description of the error.
# The data is stored as a comma-separated values in a single table, where each line
# contains a time-stamp and then the values of the five sensor readings.
# The data contains data points for the period 2021-01-02T09:20:00Z to 2021-01-02T09:39:00Z.
# The data is located at https://userstudystorageaccount.blob.core.windows.net/mvad-user-study/sensors2.csv

def task5(model_id: str) -> int | str:
    # Code goes here
    return None

# message = task5(model_id)
# print(message)

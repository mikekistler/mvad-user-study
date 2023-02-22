# Multivariate Anomaly Detector User Study

Anomaly Detector is an AI service with a set of APIs, which enables you to monitor and detect anomalies in your time series data with little machine learning (ML) knowledge, either batch validation or real-time inference.

## Anomaly Detector capabilities

With Anomaly Detector, you can either detect anomalies in one variable using Univariate Anomaly Detector, or detect anomalies in multiple variables with Multivariate Anomaly Detector.

This user study will focus on the Multivariate Anomaly Detector capability.

## Multivariate Anomaly Detection

The **Multivariate Anomaly Detection** APIs enable developers by easily integrating advanced AI for detecting anomalies from groups of metrics, without the need for machine learning knowledge or labeled data. Dependencies and inter-correlations between up to 300 different signals are now automatically counted as key factors. This new capability helps you to proactively protect your complex systems such as software applications, servers, factory machines, spacecraft, or even your business, from failures.

![Line graph for multiple variables including: rotation, optical filter, pressure, bearing with anomalies highlighted in orange.](https://raw.githubusercontent.com/MicrosoftDocs/azure-docs/main/articles/cognitive-services/Anomaly-Detector/media/multivariate-graph.png)

Imagine 20 sensors from an auto engine generating 20 different signals like rotation, fuel pressure, bearing, etc. The readings of those signals individually may not tell you much about system level issues, but together they can represent the health of the engine. When the interaction of those signals deviates outside the usual range, the multivariate anomaly detection feature can sense the anomaly like a seasoned expert. The underlying AI models are trained and customized using your data such that it understands the unique needs of your business. With the new APIs in Anomaly Detector, developers can now easily integrate the multivariate time series anomaly detection capabilities into predictive maintenance solutions, AIOps monitoring solutions for complex enterprise software, or business intelligence tools.

There are three processes to use Multivariate Anomaly Detection.

- Training: Use Train Model API to create and train a model, then use Get Model Status API to get the status and   model metadata.
- Inference: Use Async Inference API to trigger an asynchronous inference process and use Get Inference results API to get detection results on a batch of data. You could also use Sync Inference API to trigger a detection on one timestamp every time.
- Other operations: List Model API and Delete Model API are supported in Multivariate Anomaly Detection model for model management.


<!-- 
Source: https://learn.microsoft.com/en-us/azure/cognitive-services/Anomaly-Detector/overview
-->

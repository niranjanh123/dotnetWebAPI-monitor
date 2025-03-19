# dotnetWebAPI-monitor

## 📡 Overview
This project is a .NET 8 Web API that integrates with Prometheus and Grafana for monitoring application performance and API metrics.

## 🚀 Features
- Expose application metrics using Prometheus
- Monitor request latency and error rates
- Configure Grafana dashboards for data visualization

## 🛠️ Prerequisites
- .NET 8 SDK
- Docker and Docker Compose
- Prometheus and Grafana configured in Docker

## 📦 Installation
1. Clone the repository:
```bash
git clone https://github.com/niranjanh123/dotnetWebAPI-monitor.git
```

2. Run the Project locally:
   Open Visual Studio 2022 and build the Project. Once the build is successful, run the project and test out the API's. You should also be able to access HTTP://localhost:5279/metrics to view the data scraped by Prometheus. 

3. Create the docker image using the Dockerfile
```bash
cd Prometheus_Scraping
docker build -t scraping .
```

3. Move back to root folder and run Docker Compose
```bash
cd ..
docker-compose up -d
docker ps
```
You should see:
- prometheus_scraping
- prometheus
- grafana

4. You should be able to access:
   - Prometheus at http://localhost:9090
   - Grafana at http://localhost:3000
   - API at http://localhost:9095/Hello
   - To access Metrics: http://localhost:9095/metrics

5. Login to Grafana
   - Username: admin
   - Password: admin
   You will have to create a new password and you will be able to successfully login.

6. 
   



﻿#I "../../bin/XPlot.GoogleCharts/netstandard2.0"
#r "XPlot.GoogleCharts.dll"

open XPlot.GoogleCharts

let data = ["Memory", 80; "CPU", 55; "Network", 68]

let options =
    Options(
        width = 400,
        height = 120,
        redFrom = 90,
        redTo = 100,
        yellowFrom = 75,
        yellowTo = 90,
        minorTicks = 5
    )

let test =
    Chart.Gauge data
    |> Chart.WithOptions options
    |> Chart.Show

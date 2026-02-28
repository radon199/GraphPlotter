# GraphPlotter
Graph plotter debug module for UE5

Use it to plot debug graphs to the screen.

Licensed under MIT license. See LICENSE file in the project root.

![GraphPlotter cover screenshot](/Resources/cover_screenshot.png?raw=true "UE4 GraphPlotter graphs in Unreal Tournament")

Features
--------

- Draw multiple graphs at once
- Specify graph position and size
- Specify graph bg, line and reference line colors
- Specify range of displayed values
- Place reference line at any position on the graph
- Change graph bg color dynamically (through delegate)

[Video](https://youtu.be/AEIqbp3qvms "UE4 GraphPlotter module")<br>

Resources
---
* [Blog Post](https://bartlomiejwolk.wordpress.com/2017/06/29/ue4-graphplotter-module/)    

Quick Start
------------------

- Clone repository (or extract [zip package](https://github.com/bartlomiejwolk/GraphPlotter/archive/master.zip)) to any location in your project's `Source` folder
- Add _GraphPlotter_ module to `.uproject` file
```
	"Modules": [
		}
			"Name": "YourGame",
			"Type": "Runtime",
			"LoadingPhase": "Default",
			"AdditionalDependencies": [
				"Engine"
			]
		},
		{
			"Name": "GraphPlotter",
			"Type": "Runtime",
			"LoadingPhase": "Default",
			"AdditionalDependencies": [
				"Engine"
			]
		}
	],
```
- Add _GraphPlotter_ module to your game project  `.Target.cs` file
```
	ExtraModuleNames.AddRange( new string[] { "YourGame", "GraphPlotter" } );
```
- Add _GraphPlotter_ module to your game module `.build.cs` file
```
	PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput", "GraphPlotter" });
```
- In a class that you want to debug, create class fields for `FGp_Graph` and `FGp_GraphPlotter`
```
#include "Graph.h"
#include "GraphPlotter.h"
```
```
private:
 FGp_Graph MyGraph; 
 FGp_GraphPlotter MyGraphPlotter;
```
- In class constructor initialize `FGp_Graph` instance
```
  FpsGraph.Title = "FPS"; 
  FpsGraph.BgColor = FGp_Color::BgYellow; 
  FpsGraph.Range = FGp_Range(0, 120.f); 
  FpsGraph.Position = FVector2D(5.f, 200.f); 
  FpsGraph.ReferenceLineConfig.Enabled = true; 
  FpsGraph.ReferenceLineConfig.PositionValue = 60.f;
```
- In your class methods, call `<graph_instance>::AddDataPoint(float)` to add a data point(s) to your graph(s).
- In your debug method, eg. `AActor::DisplayDebug()` call `<graphplotter_instance>::Plot(UCanvas, FGp_Graph)`
to plot debug data to the screen.
- When in game call `DrawDebug` to display the debug information for the active AActor.

Check [Blog Post](https://bartlomiejwolk.wordpress.com/2017/06/29/ue4-graphplotter-module/) to see how _GraphPlotter_ can be added to _Unreal Tournament_.

Help
-----

Just create an issue and I'll do my best to help.

Contributions
------------

Pull requests, ideas, questions and any feedback at all are welcome.

Versioning
----------

Example: `v0.2.3f1`

- `0` Introduces breaking changes.
- `2` Major release. Adds new features.
- `3` Minor release. Bug fixes and refactoring.
- `f1` Quick fix.

[Semantic Versioning Specification](http://semver.org/)

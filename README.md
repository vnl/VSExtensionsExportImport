# VS Extensions Export/Import

<!-- Replace this badge with your own-->
[![Build status](https://ci.appveyor.com/api/projects/status/hv6uyc059rqbc6fj?svg=true)](https://ci.appveyor.com/project/madskristensen/extensibilitytools)

<!-- Update the VS Gallery link after you upload the VSIX-->
Download this extension from the [VS Gallery](https://visualstudiogallery.msdn.microsoft.com/[GuidFromGallery])
or get the [CI build](http://vsixgallery.com/extension/1af89e05-b2dc-49ec-8e91-1521f83f7467/).

---------------------------------------

Provides the ability to Export the list of Visual Studio extensions and then Import the updated and compatible versions of the extensions. 

See the [change log](CHANGELOG.md) for changes and road map.

### How it works

Right now, the extension supports an export/import feature, allowing you to easily setup a new VS instance with all your favourite extensions.

You can perform the export and import via a fly-out menu located in the `Tools` menu.


Exporting let's you write a file to disk of your currently installed extensions, which can be imported elsewhere using the `Import` menu option. 
An import will install any extensions you don't already have. 

## Contribute
Check out the [contribution guidelines](CONTRIBUTING.md)
if you want to contribute to this project.

For cloning and building this project yourself, make sure
to install the
[Extensibility Tools 2017](https://visualstudiogallery.msdn.microsoft.com/ab39a092-1343-46e2-b0f1-6a3f91155aa6)
extension for Visual Studio which enables some features
used by this project.

## License
[Apache 2.0](LICENSE)
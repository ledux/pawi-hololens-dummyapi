# pawi-hololens-dummyapi
REST API serving dummy data for a proof of concept project with a MS Hololens for HSLU (www.hslu.ch)

## Prerequisites

The Solution only uses standard functionality. However it is recommended to install the latest .NET
runtimes.

- .NET Framework 4.5.2
- IIS >= 7.5

### Install IIS

On Windows 10

1. Start --> Turn Windows Features on or off
    a. Internet Information Services --> Web Management Tools check...
        - IIS Management Console
        - IIS Management Scripts and Tools
        - IIS Management Service
    a. Internet Information Services --> World Wide Web Services check...
        - Applicationn Developement Features
        - Common HTTP Features


## Install

1. Open the Solution in Visual Studio as Administrator
1. Rightclick on the project in the Solution Explorer --> Publish
1. Select "Custom" publish target --> Profile Name: local --> Next
1. Publish method: "File System"
    a. Local IIS
    a. IIS Sites --> Default Web Site
    a. Create new Web Application --> "HoloApi" --> Open
    a. Next --> Next --> Publish

You can now access the API through http://localhost/HoloApi/api/1

The last segment can be any number from 1 to 4


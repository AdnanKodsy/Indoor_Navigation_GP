An augmented reality indoor navigation app made using Google ARCore and Unity

### Installing

Install Unity and open the project in Unity using Unity Hub on your system.

Cloning the project should include all the required libraries and plugins. However, if errors show up, the following can be done to manually get the application running. 

Install the ARCore SDK for Unity from [here](https://github.com/google-ar/arcore-unity-sdk/releases). The full guide can be found at [Quickstart for Android](https://developers.google.com/ar/develop/unity/quickstart-android) page at the Google Developers site.

Things should load up smoothly. Warnings may be ignored.

For Android and iOS support, Android Development and iOS Development plugins should be installed as well. iOS support was not extensively tested and might require some additional effort to get it running. ARKit plugin must also be installed if working on iOS.



## Deployment

Might need to install Android Studio with the Android SDK and JDK for exporting the app to an Android device.

For exporting an app to iOS, Xcode (11.3 or above) must be installed on a Mac running macOS 10.14 Mojave or later. An Apple Developer account is required for signing the application.

For a quick demo, an apk file has been attached as `pathmarkARX.apk` which can be installed on an Android device. The apk compatibility cannot be guaranteed.



## Motivation

Imagine going to a mall and getting lost in the maze of shops. If an augmented reality app could guide users to their destination using the shortest path, it could save users from a lot of hassle and save time.

This app can also be used when exploring unknown places or trekking so that a path can be traced back to the source.



### Applications


#### Malls & Airports
At the entrance, the user will be shown a list of all the shops. Once a destination is selected, a stored AR path is shown.
This service can be made available to a selected number of shops who are paid members.
A subscription model can be implemented for businesses if they wish to stay on the app.

#### Promoted Businesses
Businesses who would like to be promoted can have their places suggested when the app is being used for navigation. This will need to be as unintrusive as possible.

#### Integration with Maps
Once the destination is close enough, Google Maps does not provide the best user experience. In that case an indoor AR application seems more suited to the cause.


## Built With

* [Unity](http://www.unity.com/) - Cross-platform real-time game engine developed by Unity Technologies
* [ARCore](https://developers.google.com/ar) - A software development kit developed by Google that allows for augmented reality applications to be built
* [Microsoft Visual Studio](https://visualstudio.microsoft.com/) - Integrated development environment for C# from Microsoft
* [Visual Studio Code](https://code.visualstudio.com) - An open source code editor developed by Microsoft 

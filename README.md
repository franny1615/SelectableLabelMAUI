# Selectable Label .NET MAUI

[Based on this Xamarin Work](https://medium.com/@HeikkiDev/selectable-label-on-xamarin-forms-9b050267bf8e)

[Custom Handler in MAUI Documentation](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/handlers/create?view=net-maui-8.0)


### Usage
1. Add the following ItemGroups to .csproj file
```
<!-- Android -->
<ItemGroup Condition="$(TargetFramework.StartsWith('net8.0-android')) != true">
    <Compile Remove="**\**\*.Android.cs" />
    <None Include="**\**\*.Android.cs" Exclude="$(DefaultItemExcludes);$(DefaultExcludesInProjectFolder)" />
</ItemGroup>

<!-- iOS and Mac Catalyst -->
<ItemGroup Condition="$(TargetFramework.StartsWith('net8.0-ios')) != true AND $(TargetFramework.StartsWith('net7.0-maccatalyst')) != true">
    <Compile Remove="**\**\*.MaciOS.cs" />
    <None Include="**\**\*.MaciOS.cs" Exclude="$(DefaultItemExcludes);$(DefaultExcludesInProjectFolder)" Condition=" '$(EnableDefaultCompileItems)' == 'true' " />
</ItemGroup>
```
2. Copy contents of **Controls** folder to your project.
3. In MauiProgram.cs call
```
...
builder.UseSelectableLabel();
...
```
4. And that's it. You're ready to use the **SelectableLabel**


## Screenshots

### iOS
![ios](/Screenshots/ios.PNG)

### Android
![android](/Screenshots/android.JPG)
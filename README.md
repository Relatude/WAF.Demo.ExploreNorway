# Explore Norway site

This is a dotnet template used in the nuget package [Relatude.Demos](https://www.nuget.org/packages/Relatude.Demos).  
We use https://github.com/Relatude/WAF.Demo.DemoBuilder to build it.  
The template has a template configuration file here: [.template.config/template.json](https://github.com/Relatude/WAF.Demo.ExploreNorway/blob/main/.template.config/template.json)  

This project contains the Explore Norway demo, which is also hosted on https://explorenorwaycore.azurewebsites.net (`ExploreNorwayCore` app service).
<br />
<br />
Since this is a dotnet template, we need the repo to be a fully functional project, including content and database. 
This is also a live demo, and we potentially want to update the db quite frequently, therefore the Relatude.setup file in this repo simply points to a .setup file hosted on https://relatude.com, so we don't need to commit db-changes to the repo constantly.
<br />
<br />
**Keep in mind that any changes done to (files in) this repo will end up as part of this template on [nuget.org](https://www.nuget.org).**  
**No junk files!**  
**No personal or sensitive data!**  
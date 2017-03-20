
https://frhagn.github.io/Typewriter/pages/getting-started.html


Getting started

Getting started with Typewriter is easy, give it a try by following the steps below.
Install Typewriter

You can download the Typewriter extension from the Visual Studio Gallery or install it inside Visual Studio from the Extensions and Updates menu by searching for Typewriter. You'll need to restart Visual Studio for the extension to load.

Typewriter is available for Visual Studio 2013 and later.
Create your first template
Add a TypeScript Template

When Typewriter is installed it also adds a new file type to Visual Studio, TypeScript Template (*.tst). TypeScript Templates are available in the "Add new item"-dialog under the category "Web".

Add a new TypeScript Template named Models.tst and paste the following code in the new file.

module App { $Classes(*Model)[
    export class $Name { $Properties[
        public $name: $Type;]
    }]
}

Add C# class

Add a C# class named CustomerModel.cs and paste the following code in the new file.

using System;
using System.Collections.Generic;

namespace Demo 
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<OrderModel> Orders { get; set; }
    }
}

Done

That's it, you now have a template that will track any changes to your C# code and when it finds a class matching the filter (*Model) it will automatically add, update or delete a corresponding TypeScript-file.

A new TypeScript file, CustomerModel.ts, have been generated and added to your project (under the Models.tst node in the Solution Explorer).

module App { 
    export class CustomerModel {
        public id: number;
        public name: string;
        public orders: OrderModel[];
    }
}

Code model

The Typewriter code model is what you use to access metadata about your C# classes, properties, methods etc. You access the code model by typing $ followed by a keyword e.g. $Classes which will return all public classes. Since $Classes is a collection of classes you also need to add a template that will be repeated for each class by adding [] after the keyword e.g. $Classes[...]. Everything between [ and ] will be repeated for each item in the collection e.g. $Properties[public $name: $Type;]. Primitive keywords like $Name, does not require a template.
Filters

Filters are used to determine which C# files should be rendered by a specific template. Because of this all templates must have at least one filter, otherwise the template won't be rendered. You can add a filter to any collection in the code model e.g. $Classes or $Properties.
Add a Filter by adding () between the keyword and the template e.g. $Interfaces(filter)[...].
Simple filters

The easiest way to add a filter is by using a simple filter. Simple filters are just strings with optional wildcards (*) that matches the name or full name of the items in the collection. So $Classes(*Models)[...] matches classes ending in "Model" and $Classes(Application.Api.*Model)[...] matches classes ending in "Model" and with a namespace that starts with Application.Api.

You can also filter on attributes and inheritance. Attribute filters are wrapped in [] e.g. $Methods([Route])[...] matches methods with a Route attribute.
Inheritance filters are prefixed by : e.g. $Classes(:ApiController)[...] matches classes that inherits from ApiController. Inheritance filters also matches implemented interfaces.
Lambda filters

In addition to the simple filters you can also use lambda predicates to create more advanced filters. e.g. $Enums(e => e.Name.StartsWith("Color"))[...]
Custom methods

You can extend the code model by adding custom methods to your template. To add a custom code block you type ${ } at the beginning of the template. Within this code block you can add using-statements and custom methods. Methods that take a single parameter of a code model type, e.g. Class or Method, will be available in the template.
Example

${
    string LoudName(Class c)
    {
        return c.Name.ToUpperInvariant();
    }
}
module App { $Classes(*Model)[

    export class $LoudName {
        // ... 
    }]
}

In this example $LoudName will call the custom method.
Settings

Typewriter templates provide a settings API via the template constructor. The settings API allows you to specify which projects are included when rendering the template and configure the output filename and file extension.
Example

${
    Template(Settings settings)
    {
        settings
            .IncludeCurrentProject()
            .IncludeProject("Project.Name");
        
        settings.OutputExtension = ".tsx";
    }
}

Extensions

Typewriter provides extension methods for common tasks. To enable extension methods, add a code block with the appropriate using statement for the extensions you want to use.
Example

${
    using Typewriter.Extensions.WebApi;
}
module App { $Classes(:ApiController)[
    export class $Name {
        constructor(private $http: ng.IHttpService) {
        } $Methods[
        
        public $name = ($Parameters[$name: $Type][, ]) => {
            return this.$http({ url: `$Url`, method: "$HttpMethod", data: $RequestData });
        }]
    }]
}

In this example $Url, $HttpMethod and $RequestData are extensions.

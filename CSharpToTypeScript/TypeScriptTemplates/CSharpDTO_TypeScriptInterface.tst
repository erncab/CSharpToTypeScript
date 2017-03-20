${
    // Enable extension methods by adding using Typewriter.Extensions.*
    using Typewriter.Extensions.Types;

    // Uncomment the constructor to change template settings.
    //Template(Settings settings)
    //{
    //    settings.IncludeProject("Project.Name");
    //    settings.OutputExtension = ".tsx";
    //}

    // Custom extension methods can be used in the template by adding a $ prefix e.g. $LoudName
    string LoudName(Property property)
    {
        return property.Name.ToUpperInvariant();
    }

    string CustomClass(Class classObject)
    {
        //return "I" + classObject.Name.Replace("Model", "");
        return classObject.Name;
    }

    string DataType(Class classObject)
    {
        return "I" + classObject.Name.Replace("Model", "");
    }
}
module CSharpToTypeScript.TypeScriptTemplates {  
    $Classes(*)[
    export class $CustomClass {
        $Properties[
        $name: $Type;]

    }]
}


module CSharpToTypeScript.TypeScriptTemplates {  
    
    export class User {
        
        id: number;
        guid: string;
        firstName: string;
        lastName: string;
        nameToPrint: string;
        userUpdatedId: number;
        officerId: number;
        jobTitleId: number;
        hasAdditionalRegions: boolean;
        expiryDate: Date;
        dateUpdated: Date;
        homeRegion: Region;
        regions: Region[];
        authorizingLevel: AuthorizingLevel;
        contactInfo: ContactInfo;

    }
}

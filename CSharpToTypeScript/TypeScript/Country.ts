
module TypeScript.Models {  
    
    export class Country { 
        
        id: number;
        nameEn: string;
        nameFr: string;
        otherCountry: string;
        countryNumber: string;

        constructor(id: number,
                    nameEn: string,
                    nameFr: string,
                    otherCountry: string,
                    countryNumber: string) {
        }
    }
}

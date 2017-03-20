
module TypeScript.Models {  
    
    export class Province { 
        
        id: number;
        groupId: number;
        nameEn: string;
        nameFr: string;
        code: string;

        constructor(id: number,
                    groupId: number,
                    nameEn: string,
                    nameFr: string,
                    code: string) {
        }
    }
}

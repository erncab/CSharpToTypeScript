
module TypeScript.Models {  
    
    export class Customer { 
        
        firstName: string;
        lastName: string;
        email: string;
        dateOfBirth: Date;
        age: number;

        constructor(firstName: string,
                    lastName: string,
                    email: string,
                    dateOfBirth: Date,
                    age: number) {
        }
    }
}

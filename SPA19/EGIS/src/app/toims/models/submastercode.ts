export interface MasterSubcode {
    id: number;
    description: string;
    code : number;
    subcode : number;
 }

 export type createMasterSubCodeDto =Omit<MasterSubcode,'code'|'description'|'subcode'>;
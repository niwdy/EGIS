export interface Mastercode {
    id: number;
    description: string;
    code : number;
 }

 export type createMasterCodeDto =Omit<Mastercode,'code'|'description'>;
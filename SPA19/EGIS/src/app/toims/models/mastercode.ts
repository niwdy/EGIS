export interface Mastercode {
    id: number;
    description: string;
    subcode : number;
 }

 export type createMasterCodeDto =Omit<Mastercode,'subcode'|'description'>;
import { Component, Inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { MasterSubcode } from '../models/submastercode';
import { MatFormFieldModule } from '@angular/material/form-field';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatCardModule } from '@angular/material/card';
import { MatSelectModule } from '@angular/material/select';

@Component({
  selector: 'app-master-sub-code-dialog',
  imports: [
    ReactiveFormsModule,
    MatFormFieldModule,
    CommonModule,
    MatInputModule,
    MatCardModule,
    MatSelectModule,
  ],
  templateUrl: './master-sub-code-dialog.component.html',
  styleUrl: './master-sub-code-dialog.component.css'
})
export class MasterSubCodeDialogComponent {

  form:FormGroup;
  isEditMode:boolean;

  constructor(
    private fb: FormBuilder,
    private dialogRef:MatDialogRef<MasterSubCodeDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data:MasterSubcode
  )
  {
    this.isEditMode=!!data.id;
    this.form=this.fb.group({
      id:[data.id],
     // code:[data.code || '',[Validators.required]],
      subcode:[data.subcode || '', [Validators.required]],
      description:[data.description || '',[Validators.required]],
     
    })
  }

  onSubmit():void{
    if(this.form.valid){
      this.dialogRef.close(this.form.value);
    }
  }
  onCancel():void{
    this.dialogRef.close();
  }

  selectedOption: string | undefined;
  
  options = [
    { value: '100', viewValue: '100' },
    { value: '200', viewValue: '200' },
    { value: '300', viewValue: '300' }
  ];
}

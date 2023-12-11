# Intel-gyunggi2
## Intel-gyunggi2
### Intel-gyunggi2
#### Intel-gyunggi2
'''
	if(val == 0) //for(int i = 0;i < val; i++)  //
	{
		HAL_GPIO_TogglePin(LD2_GPIO_Port, LD2_Pin);  // LED On
		//HAL_GPIO_WritePin(LD2_GPIO_Port, LD2_Pin, 1);  // LED On
		HAL_Delay(200);	// delay 1 second
		//HAL_GPIO_WritePin(LD2_GPIO_Port, LD2_Pin, 0);  // LED Off
		//HAL_Delay(200);	// delay 1 second
		//flag = 0;
	}
	else
		HAL_GPIO_WritePin(LD2_GPIO_Port, LD2_Pin, 0);  // LED Off
'''

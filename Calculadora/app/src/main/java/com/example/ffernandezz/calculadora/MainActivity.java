package com.example.ffernandezz.calculadora;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {


    String total="";
    double v1,v2;
    String signo="";
    String operacion="";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void onClick(View v){
        Button newButton=(Button)v;
        String str=newButton.getText().toString();
        total+=str;
        EditText newEditT=(EditText) findViewById(R.id.editText);
        newEditT.setText(total);
        operacion+=str;

    }

    public  void onAdd(View v){
        v1=Double.parseDouble(total);
        total="";
        Button NewButton=(Button)v;
        String str=NewButton.getText().toString();
        signo=str;
        EditText NewEditT=(EditText)findViewById(R.id.editText);
        NewEditT.setText("");
        operacion+=str;
    }

    public void onCalculate(View v){
        EditText NewEdit=(EditText)findViewById(R.id.editText);
        String str=NewEdit.getText().toString();
        TextView NewTextV=(TextView)findViewById(R.id.textView);
        v2=Double.parseDouble(str);
        double resultado=0;

        if(signo.equals("-"))
        {
            resultado=v1-v2;
        }
        else if(signo.equals("+"))
        {
            resultado=v1+v2;
        }
        else if(signo.equals("*"))
        {
            resultado=v1*v2;
        }
        else if(signo.equals("/"))
        {
            if(v2!=0)
            {
                resultado=v1/v2;
            }
            resultado=0;

        }

        NewEdit.setText(resultado+"");
        NewTextV.setText(operacion);
    }

    public void onClear(View v){
        EditText NewEdit=(EditText)findViewById(R.id.editText);
        NewEdit.setText("");
        total="";
        TextView NewTextV=(TextView)findViewById(R.id.textView);
        NewTextV.setText("");
        operacion="";
    }
}

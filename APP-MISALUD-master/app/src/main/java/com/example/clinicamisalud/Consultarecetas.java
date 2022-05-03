package com.example.clinicamisalud;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONException;

import java.util.ArrayList;

public class Consultarecetas extends AppCompatActivity {
    TextView txtNPaciente,txtFechaC,txtHoraC,txtEspecialidaC,txtPlan,txtSucursC,txtMotivo,txtDiagnostico;
    Button cerrar;
String usuario,contraseña;
int idObtenido;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_consultarecetas);
        Bundle bundle = getIntent().getExtras();
        usuario = bundle.getString("email");
        contraseña= bundle.getString("pass");
        idObtenido = bundle.getInt("idcons");
        txtNPaciente=findViewById(R.id.txtNPaciente);
        txtFechaC=findViewById(R.id.txtFechaC);
        txtHoraC=findViewById(R.id.txtHoraC);
        txtEspecialidaC=findViewById(R.id.txtEspecialidaC);
        txtPlan=findViewById(R.id.txtPlan);
        txtSucursC=findViewById(R.id.txtSucursC);
        txtMotivo=findViewById(R.id.txtMotivo);
        txtDiagnostico=findViewById(R.id.txtDiagnostico);
        cerrar= findViewById(R.id.cerrar);
        String paciente = ("https://apiapps.misalud.com.sv/detallesconsultas/" + usuario + "/" + contraseña + "/"+idObtenido);
        ObtenerPerfil(paciente);

        cerrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
              //  Toast.makeText(Consultarecetas.this, "PROCESO CULMINADO",Toast.LENGTH_SHORT).show();
                Intent intent = new Intent(Consultarecetas.this, Agenda.class);
                intent.putExtra("email", usuario);
                intent.putExtra("pass", contraseña);
                startActivity(intent);
            }
        });

    }

    public void ObtenerPerfil(String URL){
        Log.i("url consulta api: ",""+URL);
        RequestQueue queue = Volley.newRequestQueue(this);
        StringRequest stringRequest = new StringRequest(Request.Method.GET, URL, new Response.Listener<String>() {
            @Override
            public void onResponse(String response) {
                String response1 = response.replace(":",",");
                String response2 = response1.replace("[{","[");
                String response3 = response2.replace("}]","]");

                if (response3.length()>0){
                    try {
                        JSONArray ag =new JSONArray(response3);
                        ListaDatos(ag);
                   /*     txtExpediente.setText(""+vExpediente);
                        txtDoctor.setText(""+vDoctor);
                        txtPaciente.setText(""+vPaciente);
                        txtFecha.setText(""+vFecha);
                        txtInicioHora.setText(""+vInicioHora);
                        txtFinHora.setText(""+vFinHora);
                        txtEspecialida.setText(""+vEspecialida);
                        txtProcedim.setText(""+vProcedim);
                        txtSucurs.setText(""+vSucurs);
                        txtEstadocita.setText(""+vEstadocita);
                        txtObservacion.setText(""+vObservacion);
                    */

                    } catch (JSONException e) {
                        e.printStackTrace();
                    }
                }
            }
        }, new Response.ErrorListener(){
            @Override
            public void onErrorResponse(VolleyError error) {

            }
        });
        queue.add(stringRequest);
    }

    public void ListaDatos(JSONArray ja){

        ArrayList<String> lista = new ArrayList<>();

        for(int i=0;i<ja.length();i+=17){
            try {
                String hora1=ja.getString(i+9);
                String Hora=hora1.replace(",",":");
               txtNPaciente.setText("    "+ja.getString(i+1));
               txtDiagnostico.setText("    "+ja.getString(i+3));
               txtMotivo.setText("    "+ja.getString(i+5));
               txtFechaC.setText("    "+ja.getString(i+7));
               txtHoraC.setText("    "+Hora);
               txtEspecialidaC.setText("    "+ja.getString(i+13));
               txtPlan.setText("    "+ja.getString(i+15));
               txtSucursC.setText("    "+ja.getString(i+17));
                lista.add("Hora inicio: "+hora1);
            } catch (JSONException e) {
                e.printStackTrace();
            }
        }
    }

}
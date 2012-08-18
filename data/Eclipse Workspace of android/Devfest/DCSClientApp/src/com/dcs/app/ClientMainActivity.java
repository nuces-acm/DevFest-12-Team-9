package com.dcs.app;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.Toast;

public class ClientMainActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.main);
		((Button) findViewById(R.id.testsButton))
				.setOnClickListener(new OnClickListener() {

					public void onClick(View v) {
						startActivity(new Intent(ClientMainActivity.this,
								TestsActivity.class));
					}
				});

		((Button) findViewById(R.id.prescriptionsButton))
				.setOnClickListener(new OnClickListener() {

					public void onClick(View v) {
						Toast.makeText(ClientMainActivity.this,
								" Prescriptions Button", Toast.LENGTH_SHORT)
								.show();
					}
				});

		((Button) findViewById(R.id.call))
				.setOnClickListener(new OnClickListener() {

					public void onClick(View v) {
						Toast.makeText(ClientMainActivity.this, " Call Doctor!",
								Toast.LENGTH_SHORT).show();
					}
				});

	}

}

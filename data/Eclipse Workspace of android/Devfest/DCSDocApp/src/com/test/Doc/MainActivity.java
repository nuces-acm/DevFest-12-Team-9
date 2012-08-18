package com.test.Doc;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemSelectedListener;
import android.widget.ArrayAdapter;
import android.widget.Spinner;

public class MainActivity extends Activity implements OnItemSelectedListener {
	String[] items = { "Sort By"};

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.main);

		Spinner spin = (Spinner) findViewById(R.id.spinner);
		spin.setOnItemSelectedListener(this);

		ArrayAdapter aa = new ArrayAdapter(this,
				android.R.layout.simple_spinner_item, items);

		aa.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		spin.setAdapter(aa);
	}

	public void onItemSelected(AdapterView<?> arg0, View arg1, int arg2,
			long arg3) {
		// TODO Auto-generated method stub

	}

	public void onNothingSelected(AdapterView<?> arg0) {
		// TODO Auto-generated method stub

	}

}

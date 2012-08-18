package com.dcs.app;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.ViewGroup.LayoutParams;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemSelectedListener;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.Spinner;
import android.widget.TextView;

public class SubmitATestActivity extends Activity implements
		OnItemSelectedListener, OnClickListener {
	LinearLayout linearLayout;
	String[] items = { "Dengue", "CBC", "Custom" };

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.submitatest);
		linearLayout = (LinearLayout) findViewById(R.id.linear);

		Spinner spin = (Spinner) findViewById(R.id.spinner);
		spin.setOnItemSelectedListener(this);

		ArrayAdapter aa = new ArrayAdapter(this,
				android.R.layout.simple_spinner_item, items);

		aa.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		spin.setAdapter(aa);

		//setLayoutToDengue();
		
		((Button) findViewById(R.id.addButton))
		.setOnClickListener(new OnClickListener() {

			public void onClick(View v) {
				addPair();
			}
		});
	}

	public void onItemSelected(AdapterView<?> parent, View v, int position,
			long id) {
		String item = items[position];
		/*if (item.equals("Dengue")) {
			setLayoutToDengue();
		} else {
			removeItems();
			
		}*/
	}

	public void onNothingSelected(AdapterView<?> arg0) {
		// TODO Auto-generated method stub

	}

	public void setLayoutToDengue() {
		removeItems();
		for (int i = 0; i < 5; i++) {
			Button button = new Button(this);
			button.setText("" + i);
			button.setTag(i);
			button.setLayoutParams(new LayoutParams(LayoutParams.WRAP_CONTENT,
					LayoutParams.WRAP_CONTENT));
			linearLayout.addView(button);
			button.setOnClickListener(this);
		}
	}

	public void removeItems() {
		int count = linearLayout.getChildCount();
		for (int i = count - 1; i > 2; i--) {
			linearLayout.removeViewAt(i);
		}

	}

	public void addPair() {
		TextView tv = new TextView(this);
		tv.setText("Name");
		tv.setLayoutParams(new LayoutParams(LayoutParams.WRAP_CONTENT,
				LayoutParams.WRAP_CONTENT));
		linearLayout.addView(tv);

		EditText eText = new EditText(this);
		eText.setLayoutParams(new LayoutParams(LayoutParams.WRAP_CONTENT,
				LayoutParams.WRAP_CONTENT));
		eText.setMinimumWidth(100);
		linearLayout.addView(eText);

		TextView tv1 = new TextView(this);
		tv1.setText("Vlaue");
		tv1.setLayoutParams(new LayoutParams(LayoutParams.WRAP_CONTENT,
				LayoutParams.WRAP_CONTENT));
		linearLayout.addView(tv1);

		EditText eText1 = new EditText(this);
		eText1.setLayoutParams(new LayoutParams(LayoutParams.WRAP_CONTENT,
				LayoutParams.WRAP_CONTENT));
		eText1.setMinWidth(100);
		linearLayout.addView(eText1);

	}

	public void onClick(View v) {

	}

}

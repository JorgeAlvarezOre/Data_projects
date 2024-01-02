# Inspired in a video of Codebasics Youtube channel (Dhaval Patel)
# streamlit run main.py

import streamlit as st
import pandas as pd
import openai_helper

col1, col2 = st.columns([3,2])

financial_data_df = pd.DataFrame({
        "Measure": ["Company Name", "Stock Symbol", "Revenue", "Net Income", "EPS"],
        "Value": ["", "", "", "", ""]
    })

with col1:
    st.title("Data Extraction Tool")
    news_article = st.text_area("Paste your financial news article here", height=300)
    if st.button("Extract"):
        financial_data_df = openai_helper.extract_financial_data(news_article)

with col2:
    st.markdown("<br/>" * 5, unsafe_allow_html=True)  # Creates 5 lines of vertical space
    st.dataframe(
        financial_data_df,
        column_config={
            "Measure": st.column_config.Column(width=150),
            "Value": st.column_config.Column(width=150)
        },
        hide_index=True
    )

Example1 = '''Apple reported second-fiscal quarter earnings on Thursday that beat Wall Street’s soft expectations, driven by stronger-than-anticipated iPhones sales. Apple CEO Tim Cook told CNBC that the quarter was “better than we expected.” 
However, Apple’s overall sales fell for the second quarter in a row. The tech giant’s shares rose nearly 2% in extended trading, and continued climbing when Apple gave forecast data points about the current quarter.
Here’s how the company did versus Wall Street expectations per Refinitiv consensus expectations: 
EPS: $1.52 per share vs. $1.43 expected 
Revenue: $94.84 billion vs. $92.96 billion expected 
Gross margin: 44.3% vs. 44.1% expected 
Apple reported $24.16 billion in net income during the quarter compared to $25.01 billion in the year-earlier period. Total revenue was off 3% from $97.28 billion in the prior quarter.'''

Example2 = '''HDFC Bank on April 15 reported a 21 percent YoY rise in consolidated net profit to Rs 12,594.5 crore for the quarter ended March 31. The private lender posted a 20.3 percent YoY growth in consolidated net revenue to Rs 34,552.8 crore during the quarter, against Rs 28,733.9 crore recorded during the quarter ended March 31, 2022.
Profit before tax (PBT) for the quarter ended March 31, 2023 was at Rs 15,935.5 crore. After providing Rs 3,888.1 crore for taxation, the bank earned a net profit of Rs 12,047.5 crore, an increase of 19.8 percent over the quarter ended March 31, 2022.
Net interest income (NII), or the difference between interest earned and interest expended, grew by 23.7 percent to Rs 23,351 crore from Rs 18,872 crore for the quarter ended March 31, 2023, HDFC Bank said in an exchange filing.
The average of a poll of three brokerages estimated that the profits will rise to Rs 12,181 crore. Net interest income (NII) was expected to increase 30.5 percent on-year (up 8.8 percent QoQ) to Rs 24,601.9 crore, whereas the average poll of estimates saw HDFC Bank to report 21.9 percent YoY rise in March quarter profits.'''

Example3 = '''Tesla's earning this quarter blew all the estimates. They reported 4.5 billion $ profit against a revenue of 30 billion $. Their earnings per share was 2.3 $'''
# Inspired in a video of Codebasics Youtube channel (Dhaval Patel)
# Ejecutar streamlit run main.py

import streamlit as st
from openai_helper import get_answer

st.title("AtliQ College: Q&A System")

question = st.text_input("Question:")

if st.button("Ask for"):
    answer = get_answer(question)
    st.text("Answer:")
    st.write(answer)
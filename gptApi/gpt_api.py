from flask import Flask, request, jsonify
from gpt4all import GPT4All

app = Flask(__name__)
model = GPT4All("mistral-7b-openorca.Q4_0.gguf")

@app.route('/pergunta', methods=['POST'])
def pergunta():
    dados = request.get_json()
    prompt = dados["prompt"]
    with model.chat_session():
        resposta = model.generate(prompt)
    return jsonify({"resposta": resposta})

if __name__ == '__main__':
    app.run(port=5000)
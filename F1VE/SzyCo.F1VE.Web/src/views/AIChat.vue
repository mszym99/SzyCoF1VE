<template>
    <div class="chat-container">
        <div class="chat-window">
            <div class="messages" v-for="(message, index) in messages" :key="index">
                <div class="user-message" v-if="message.user">{{ message.text }}</div>
                <div class="bot-response" v-else>{{ message.text }}</div>
            </div>
        </div>
        <div class="input-area">
            <input v-model="userInput" @keyup.enter="sendMessage" placeholder="Type a message..." />
            <button @click="sendMessage">Send</button>
        </div>
    </div>
</template>

<script>
export default {
    data() {
        return {
            userInput: '',
            messages: []
        };
    },
    methods: {
        sendMessage() {
            if (this.userInput.trim() !== '') {
                this.messages.push({ text: this.userInput, user: true });
                this.userInput = '';
                this.messages.push({ text: 'tbd', user: false });
            }
        }
    }
};
</script>

<style scoped>
.chat-container {
    display: grid;
    grid-template-rows: 1fr auto;
    height: 100vh;
    width: 100%;
    position: absolute;
    max-height: 100%;
    overflow: hidden;
    padding-left: 0%;
    padding-right: 60%;
    padding-bottom: 40%
}

.chat-window {
    overflow-y: auto;
    padding: 10px;
    border: 1px solid #ccc;
}

.messages {
    margin-bottom: 10px;
}

.user-message {
    text-align: right;
    background-color: #dcf8c6;
    padding: 5px;
    border-radius: 5px;
    display: inline-block;
}

.bot-response {
    text-align: left;
    background-color: #f1f0f0;
    padding: 5px;
    border-radius: 5px;
    display: inline-block;
}

.input-area {
    display: flex;
    padding: 5px;
    padding-left: 10px;
    padding-right: 10px;
    border-top: 1px solid #ccc;
    background-color: #fff;
}

input {
    flex: 1;
    padding: 5px;
    border: 1px solid #ccc;
    border-radius: 5px;
}

button {
    padding: 5px;
    margin-left: 5px;
    border: none;
    background-color: #007bff;
    color: white;
    border-radius: 5px;
    cursor: pointer;
}

button:hover {
    background-color: #0056b3;
}
</style>
import requests

webhook_url = "https://discord.com/api/webhooks/1158587649729241118/6yJGNP876N0M7MKYSAppQc0wC47caLYiAVAH-MNbcZwWEC-_y8ZZxNgTNkj6Nm-aO6E6"
message_content = "Hello, Discord!"

payload = {
    "content": message_content
}

response = requests.post(webhook_url, json=payload)

print(response.status_code)

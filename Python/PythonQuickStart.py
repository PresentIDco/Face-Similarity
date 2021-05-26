import requests (in Rapidapi.com)



api_url = 'https://face-recognition4.p.rapidapi.com/FaceSimilar'
  api_key = 'Your API Key'

  image_path = 'Image directory path'
  image_name = 'Image name'

  files = {'Photo': (image_name, open(image_path + image_name, 'rb'), 'multipart/form-data')}
  header = {
      "x-rapidapi-host": "face-recognition4.p.rapidapi.com",
      "x-rapidapi-key": api_key
      }
  response = requests.post(api_url, files=files, headers=header)

import speech_recognition
import os
from pydub import AudioSegment
import wave
import scipy.io.wavfile
import numpy as np

def to_pcm():
    fs, data = scipy.io.wavfile.read(input_file_path)
    data = np.int16(data * 32767)
    scipy.io.wavfile.write(input_file_path, fs, data)

def lighten_wav():
    wav_file = wave.open(input_file_path, "rb")
    # PCM WAV形式のパラメータを取得
    nchannels = wav_file.getnchannels() # チャンネル数
    sampwidth = wav_file.getsampwidth() # サンプル幅
    framerate = wav_file.getframerate() # サンプリングレート
    nframes = wav_file.getnframes() # フレーム数
    comptype = wav_file.getcomptype() # 圧縮タイプ
    compname = wav_file.getcompname() # 圧縮名

    # PCM WAV形式のデータを読み込む
    pcm_data = wav_file.readframes(nframes)

    # wavファイルを閉じる
    wav_file.close()

    # PCMデータをnumpy配列に変換する
    pcm_array = np.frombuffer(pcm_data, dtype=np.int16)

    # scipyをインポートする
    from scipy import signal

    # リサンプリングする
    new_framerate = framerate // 2 # サンプリングレートを半分にする
    new_nframes = nframes // 2 # フレーム数も半分にする
    new_pcm_array = signal.resample(pcm_array, new_nframes) # リサンプリングする
    new_pcm_array = new_pcm_array.astype(np.int16) # 整数に戻す

    # numpy配列をPCMデータに変換する
    new_pcm_data = new_pcm_array.tobytes()

    # PCM WAV形式のファイルに書き込む
    output_file = wave.open(input_file_path, "wb")
    output_file.setparams((nchannels, sampwidth, new_framerate, new_nframes, comptype, compname))
    output_file.writeframes(new_pcm_data)
    output_file.close()




try:
    input_file_path = r"./input.wav"
    r = speech_recognition.Recognizer()

    i = 0
    while os.path.isfile(input_file_path) == False:
        i += 1
    
    try:
        with speech_recognition.AudioFile(input_file_path) as source:
          audio_data = r.record(source)
    except:
        to_pcm()
    
    while True:
        try:
            with speech_recognition.AudioFile(input_file_path) as source:
                audio_data = r.record(source)
            text = r.recognize_google(audio_data, language="ja-JP")

            f = open("./output.txt", "w", encoding="shift_jis")
            f.write(text)
            f.close()
            break
        except:
            lighten_wav()    
except Exception as e:
    f = open("./output.txt", "w", encoding="shift_jis")
    text = "音声の変換に失敗しました。音声が短すぎるか長過ぎる可能性があります"
    #text = str(e)
    f.write(text)
    f.close()





